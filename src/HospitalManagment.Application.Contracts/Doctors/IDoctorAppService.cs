using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace HospitalManagement.Doctors;

public interface IDoctorAppService :
    ICrudAppService<DoctorDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateDoctorDto>
{
    Task SetAvailabilityNotesAsync(Guid id, string? notes);
    Task<int> GetTodayAppointmentCountAsync(Guid doctorId, DateTime today);
}