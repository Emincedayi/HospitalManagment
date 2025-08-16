using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace HospitalManagement.Departments;

public interface IDepartmentAppService :
    ICrudAppService<DepartmentDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateDepartmentDto>
{ }