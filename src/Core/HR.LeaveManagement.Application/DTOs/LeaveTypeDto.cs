namespace HR.LeaveManagement.Application.DTOs;

public class LeaveTypeDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Default { get; set; }
    public DateTime DateCreated { get; set; }
}