﻿using HR.LeaveManagement.Domain.Common;

namespace HR.LeaveManagement.Domain;

public class LeaveAllocation : BaseEntity
{
    public string EmployeeId { get; set; } = string.Empty;
    public int NumberOfDays { get; set; }
    public LeaveType? LeaveType { get; set; }
    public int LeaveTypeId { get; set; }
    public int Period { get; set; }
}
