using System;
using Volo.Abp.Application.Dtos;

namespace HospitalManagement.Departments
{
    public class DepartmentDto : EntityDto<Guid>
    {
        public  string Name { get; set; }
    }

    public class CreateUpdateDepartmentDto
    {
        public string Name { get; set; }
    }
}
