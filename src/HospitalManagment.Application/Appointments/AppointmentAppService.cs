using HospitalManagement.Appointments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace HospitalManagment.Appointments
{
    public class AppointmentAppService : ApplicationService, IAppointmentAppService
    { 
        private readonly IAppointmentRepository _appointmentRepository;
        public AppointmentAppService(IAppointmentRepository appointmentRepository)
        {
           _appointmentRepository = appointmentRepository;
        }
        public Task<AppointmentDto> CreateAsync(AppointmentDto appointment)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
