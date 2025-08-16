using System;
using Volo.Abp.Application.Dtos;

namespace HospitalManagement.Appointments;

//public enum AppointmentStatus { Pending = 0, Confirmed = 1, Completed = 2, Cancelled = 3 }

public class AppointmentDto : AuditedEntityDto<Guid>
{
    public Guid DoctorId { get; set; }
    public Guid PatientId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public AppointmentStatus Status { get; set; }
    public string? Notes { get; set; }
}

public class CreateAppointmentDto
{
    public Guid DoctorId { get; set; }
    public Guid PatientId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string? Notes { get; set; }
}

public class UpdateAppointmentDto
{
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public AppointmentStatus Status { get; set; }
    public string? Notes { get; set; }
}