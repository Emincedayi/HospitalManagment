using HospitalManagement.Departments;
using HospitalManagement.Doctors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace HospitalManagment.Doctors
{
    public class DoctorAppService : ApplicationService, IDoctorAppService
    { 
        private readonly IDoctorRepository _doctorRepository;
        public DoctorAppService(IDoctorRepository doctorRepository)
        {
          _doctorRepository = doctorRepository;
        }
        public Task<DoctorDto> CreateAsync(DoctorDto appointment)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
