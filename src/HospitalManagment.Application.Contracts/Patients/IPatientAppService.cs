using HospitalManagement.Departments;
using HospitalManagement.Patients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace HospitalManagment.Patients
{
    public interface IPatientAppService : IApplicationService
    {
        Task<PatientDto> CreateAsync(PatientDto appointment);
        Task DeleteAsync(Guid id);
    }
}
