using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace HospitalManagement.Departments
{
    public interface IDepartmentAppService : IApplicationService 
    {
        Task<DepartmentDto> CreateAsync( string title, string name);
        Task<List<Department>> GetListAsync(Guid id, string title, string name);
        Task DeleteAsync(Guid id);
    }
}
