using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace HospitalManagement.Patients;

public interface IPatientAppService :
    ICrudAppService<PatientDto, Guid, PagedAndSortedResultRequestDto, CreateUpdatePatientDto>
{ }