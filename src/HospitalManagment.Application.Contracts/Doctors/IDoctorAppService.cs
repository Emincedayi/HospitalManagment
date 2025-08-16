using HospitalManagement.Departments;
using HospitalManagement.Doctors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace HospitalManagment.Doctors
{
    public interface IDoctorAppService : IApplicationService
    {
        Task<DoctorDto> CreateAsync(DoctorDto appointment);
        Task DeleteAsync(Guid id);
    }
}
