using System;
using Volo.Abp.Application.Dtos;

namespace HospitalManagement.Departments;

public class DepartmentDto : AuditedEntityDto<Guid>
{
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
}

public class CreateUpdateDepartmentDto
{
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
}