using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace HospitalManagement.Appointments
{
    public class Appointment : FullAuditedAggregateRoot<Guid>
    {
        public Guid DoctorId { get; set; }
        public Doctors.Doctor Doctor { get; set; }

        public Guid PatientId { get; set; }
        public Patients.Patient Patient { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        protected Appointment() { }

        public Appointment(Guid id, Guid doctorId, Guid patientId, DateTime startTime, DateTime endTime)
            : base(id)
        {
            DoctorId = doctorId;
            PatientId = patientId;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
