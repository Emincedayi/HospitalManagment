using HospitalManagement.Appointments;
using HospitalManagement.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace HospitalManagment.Appointments
{
    public interface IAppointmentAppService :  IApplicationService
    {
        Task<AppointmentDto> CreateAsync(AppointmentDto appointment);
        Task DeleteAsync(Guid id);
    }
}
