using AutoMapper;
using LeaveManagment.Web.Data;
using LeaveManagment.Web.Models;

namespace LeaveManagment.Web.Configurations;

public class MapperConfig: Profile
{
    public MapperConfig()
    {
        // source, destination
        CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        CreateMap<Employee, EmployeeListVM>().ReverseMap();
    }
}
