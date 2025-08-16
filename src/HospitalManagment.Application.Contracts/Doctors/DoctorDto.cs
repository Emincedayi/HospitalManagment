using System;
using Volo.Abp.Application.Dtos;

namespace HospitalManagement.Doctors;

public class DoctorDto : AuditedEntityDto<Guid>
{
    public Guid UserId { get; set; }
    public Guid DepartmentId { get; set; }
    public string? Specialty { get; set; }
    public string? AvailabilityNotes { get; set; }
}

public class CreateUpdateDoctorDto
{
    public Guid UserId { get; set; }
    public Guid DepartmentId { get; set; }
    public string? Specialty { get; set; }
    public string? AvailabilityNotes { get; set; }
}