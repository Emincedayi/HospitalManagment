using System;
using Volo.Abp.Application.Dtos;

namespace HospitalManagement.Patients;

public class PatientDto : AuditedEntityDto<Guid>
{
    public Guid UserId { get; set; } 

    public DateTime? DateOfBirth { get; set; }
    public string? Notes { get; set; }
}

public class CreateUpdatePatientDto
{
    public Guid UserId { get; set; }
    public Guid PatientId { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string? Notes { get; set; }
}