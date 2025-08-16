using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace HospitalManagement.Appointments;

public enum AppointmentStatus { Pending = 0, Confirmed = 1, Completed = 2, Cancelled = 3 } //shared alsam daha iyi olur

public class Appointment : FullAuditedAggregateRoot<Guid>
{
    public Guid DoctorId { get; private set; }
    public Guid PatientId { get; private set; }

    public DateTime StartTime { get; private set; }
    public DateTime EndTime { get; private set; }
    public AppointmentStatus Status { get; private set; }
    public string? Notes { get; private set; }

    private Appointment() { }

    public Appointment(Guid id, Guid doctorId, Guid patientId, DateTime startTime, DateTime endTime, string? notes = null) : base(id)
    {
        if (endTime <= startTime)
            throw new ArgumentException("EndTime must be greater than StartTime");

        DoctorId = doctorId;
        PatientId = patientId;
        StartTime = startTime;
        EndTime = endTime;
        Status = AppointmentStatus.Pending;
        Notes = notes;
    }

    public void Confirm() => Status = AppointmentStatus.Confirmed;
    public void Complete() => Status = AppointmentStatus.Completed;
    public void Cancel() => Status = AppointmentStatus.Cancelled;
}





//using System;
//using Volo.Abp.Domain.Entities.Auditing;

//namespace HospitalManagement.Appointments
//{
//    public class Appointment : FullAuditedAggregateRoot<Guid>
//    {
//        public Guid DoctorId { get; set; }
//        public Doctors.Doctor Doctor { get; set; }

//        public Guid PatientId { get; set; }
//        public Patients.Patient Patient { get; set; }

//        public DateTime StartTime { get; set; }
//        public DateTime EndTime { get; set; }

//        protected Appointment() { }

//        public Appointment(Guid id, Guid doctorId, Guid patientId, DateTime startTime, DateTime endTime)
//            : base(id)
//        {
//            DoctorId = doctorId;
//            PatientId = patientId;
//            StartTime = startTime;
//            EndTime = endTime;
//        }
//    }
//}
