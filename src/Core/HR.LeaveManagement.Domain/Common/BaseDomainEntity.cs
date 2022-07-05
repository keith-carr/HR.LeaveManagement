namespace HR.LeaveManagement.Domain.Common;

public class BaseDomainEntity
{
    public int Id { get; set; }
    public int NumberOfDay { get; set; }
    public DateTime DateTime { get; set; }
    public LeaveType LeaveType { get; set; }
    public int LeaveTypeId { get; set; }
    public int Period{ get; set; }
}