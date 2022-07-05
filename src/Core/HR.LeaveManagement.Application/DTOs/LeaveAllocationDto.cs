namespace HR.LeaveManagement.Application.DTOs;

public class LeaveAllocationDto
{
    public int NumberOfDay { get; set; }
    public DateTime DateTime { get; set; }
    public LeaveTypeDto LeaveTypeDto { get; set; }
    public int LeaveTypeId { get; set; }
    public int Period{ get; set; }
}