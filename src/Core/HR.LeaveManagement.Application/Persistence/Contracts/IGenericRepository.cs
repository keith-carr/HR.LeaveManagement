using System.Collections.Generic;

namespace HR.LeaveManagement.Application.Persistence.Contracts;

public interface IGenericRepository<T> where T : class
{
 Task<T> Get(int id);
 Task<IReadOnlyList<T>> GetAll();
}