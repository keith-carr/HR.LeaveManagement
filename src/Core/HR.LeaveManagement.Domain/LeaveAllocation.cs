using HR.LeaveManagement.Domain.Common;

namespace HR.LeaveManagement.Domain;

public class LeaveAllocation : BaseDomainEntity
{
    public int NumberOfDay { get; set; }
    public DateTime DateTime { get; set; }
    public LeaveType LeaveType { get; set; }
    public int LeaveTypeId { get; set; }
    public int Period{ get; set; }
}
