using AutoMapper;
using LeaveManagment.Web.Constants;
using LeaveManagment.Web.Contracts;
using LeaveManagment.Web.Data;
using LeaveManagment.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagment.Web.Controllers;
public class EmployeesController : Controller
{
    private readonly UserManager<Employee> _userManager;
    private readonly IMapper _mapper;
    private readonly ILeaveAllocationRepository _leaveAllocationRepository;

    public EmployeesController(UserManager<Employee> userManager, IMapper mapper, ILeaveAllocationRepository leaveAllocationRepository)
    {
        _userManager = userManager;
        _mapper = mapper;
        _leaveAllocationRepository = leaveAllocationRepository;
    }


    // GET: EmployeesController
    public async Task<IActionResult> Index()
    {
        var employees = await _userManager.GetUsersInRoleAsync(Roles.User);
        var model = _mapper.Map<List<EmployeeListVM>>(employees);
        return View(model);
    }

    // GET: EmployeesController/ViewAllocations/employeeId
    public async Task<ActionResult>ViewAllocations(string id)
    {
        var model = await _leaveAllocationRepository.GetEmployeeAllocations(id);
        return View(model);
    }

    // GET: EmployeesController/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: EmployeesController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: EmployeesController/Edit/5
    public ActionResult Edit(int id)
    {
        return View();
    }

    // POST: EmployeesController/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: EmployeesController/Delete/5
    public ActionResult Delete(int id)
    {
        return View();
    }

    // POST: EmployeesController/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }
}
