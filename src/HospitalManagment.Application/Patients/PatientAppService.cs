using HospitalManagement.Patients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace HospitalManagment.Patients
{
    public class PatientAppService : ApplicationService, IPatientAppService
    {  
        private readonly IPatientRepository _patientRepository;
        public PatientAppService(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }
        public Task<PatientDto> CreateAsync(PatientDto appointment)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
