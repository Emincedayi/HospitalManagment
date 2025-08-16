using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace HospitalManagement.Patients;

public class PatientAppService : CrudAppService<
    Patient, PatientDto, Guid, PagedAndSortedResultRequestDto,
    CreateUpdatePatientDto>, IPatientAppService
{
    public PatientAppService(IRepository<Patient, Guid> repository) : base(repository) { }
}