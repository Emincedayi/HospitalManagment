using System;
using Volo.Abp.Application.Dtos;

namespace HospitalManagement.Appointments
{
    public class AppointmentDto : EntityDto<Guid>
    {
        public Guid DoctorId { get; set; }
        public Guid PatientId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }

    public class CreateUpdateAppointmentDto
    {
        public Guid DoctorId { get; set; }
        public Guid PatientId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
