using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace HospitalManagement.Appointments;

public interface IAppointmentAppService :
    ICrudAppService<AppointmentDto, Guid, PagedAndSortedResultRequestDto, CreateAppointmentDto, UpdateAppointmentDto>
{
    Task<AppointmentDto> ConfirmAsync(Guid id);
    Task<AppointmentDto> CompleteAsync(Guid id);
    Task<AppointmentDto> CancelAsync(Guid id);

    Task<PagedResultDto<AppointmentDto>> GetListForDoctorAsync(Guid doctorId, DateTime? from = null, DateTime? to = null);
    Task<PagedResultDto<AppointmentDto>> GetListForPatientAsync(Guid patientId, DateTime? from = null, DateTime? to = null);
}