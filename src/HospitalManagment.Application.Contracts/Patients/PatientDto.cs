using System;
using Volo.Abp.Application.Dtos;

namespace HospitalManagement.Patients
{
    public class PatientDto : EntityDto<Guid>
    {
        public string FullName { get; set; }
    }

    public class CreateUpdatePatientDto
    {
        public string FullName { get; set; }
        

    }
}
