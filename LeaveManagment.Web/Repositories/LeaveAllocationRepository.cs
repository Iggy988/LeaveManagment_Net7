using AutoMapper;
using LeaveManagment.Web.Constants;
using LeaveManagment.Web.Contracts;
using LeaveManagment.Web.Data;
using LeaveManagment.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagment.Web.Repositories;

public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<Employee> _userManager;
    private readonly ILeaveTypeRepository _leaveTypeRepository;
    private readonly IMapper _mapper;

    public LeaveAllocationRepository(ApplicationDbContext context, UserManager<Employee> userManager, ILeaveTypeRepository leaveTypeRepository, IMapper mapper) : base(context)
    {
        _context = context;
        _userManager = userManager;
        _leaveTypeRepository = leaveTypeRepository;
        _mapper = mapper;
    }

    public async Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period)
    {
        return await _context.LeaveAllocations.AnyAsync(
            q => q.EmployeeId == employeeId
            && q.LeaveTypeId == leaveTypeId
            && q.Period == period);
    }

    public async Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId)
    {
        var allocations = await _context.LeaveAllocations //select
            .Include(q => q.LeaveType) //inner join
            .Where(q => q.EmployeeId == employeeId)
            .ToListAsync(); //where

        var employee = await _userManager.FindByIdAsync(employeeId);
        //get viewmodel
        var employeeAllocationModel = _mapper.Map<EmployeeAllocationVM>(employee);
        employeeAllocationModel.LeaveAllocations = _mapper.Map<List<LeaveAllocationVM>>(allocations);

        return employeeAllocationModel;
    }

    public async Task LeaveAllocation(int leaveTypeId)
    {
        var employees = await _userManager.GetUsersInRoleAsync(Roles.User);
        var period = DateTime.Now.Year;
        var leaveType = await _leaveTypeRepository.GetAsync(leaveTypeId);
        var allocations = new List<LeaveAllocation>();

        foreach (var employee in employees) 
        {
            //var allocation = new LeaveAllocation
            if (await AllocationExists(employee.Id, leaveTypeId, period))
                continue;

            allocations.Add(new LeaveAllocation
            {
                EmployeeId = employee.Id,
                LeaveTypeId = leaveTypeId,
                Period = period,
                NumberOfDays = leaveType.DefaultDays
            });

            //await AddAsync(allocation);

            await AddRangeAsync(allocations);
        }

       
    }
}
