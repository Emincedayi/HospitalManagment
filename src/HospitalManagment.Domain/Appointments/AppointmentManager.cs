using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Services;
using Volo.Abp.Domain.Repositories;

namespace HospitalManagement.Appointments
{
    public class AppointmentManager : DomainService
    {
        private readonly IRepository<Appointment, Guid> _appointmentRepository;

        public AppointmentManager(IRepository<Appointment, Guid> appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public async Task<bool> IsAvailableAsync(DateTime startTime, DateTime endTime, Guid doctorId)
        {
            var queryable = await _appointmentRepository.GetQueryableAsync();
            return !await AsyncExecuter.AnyAsync(
                queryable.Where(a => a.DoctorId == doctorId &&
                            ((startTime >= a.StartTime && startTime < a.EndTime) ||
                             (endTime > a.StartTime && endTime <= a.EndTime) ||
                             (startTime <= a.StartTime && endTime >= a.EndTime)))
            );
        }
    }
}
