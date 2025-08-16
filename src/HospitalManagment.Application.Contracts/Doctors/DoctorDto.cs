using System;
using Volo.Abp.Application.Dtos;

namespace HospitalManagement.Doctors
{
    public class DoctorDto : EntityDto<Guid>
    {
        public string FullName { get; set; }
        public Guid DepartmentId { get; set; }
    }

    public class CreateUpdateDoctorDto
    {
        public string FullName { get; set; }
        public Guid DepartmentId { get; set; }
    }
}
