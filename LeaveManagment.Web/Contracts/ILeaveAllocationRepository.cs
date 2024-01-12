﻿using LeaveManagment.Web.Data;

namespace LeaveManagment.Web.Contracts;

public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
{
    Task LeaveAllocation(int leaveTypeId);
    Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period);
}
