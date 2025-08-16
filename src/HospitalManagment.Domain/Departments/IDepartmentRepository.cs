using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace HospitalManagement.Departments
{
    public interface IDepartmentRepository : IRepository<Department, Guid>
    {
    //    Task<Department> CreateAsync(Guid id, string title, string name);
    //    Task<List<Department>> GetListAsync(Guid id, string title, string name);
    //    Task DeleteAsync(Guid id);
    }
}
