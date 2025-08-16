using HospitalManagment.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace HospitalManagement.Appointments;

public class AppointmentAppService : CrudAppService<
    Appointment, AppointmentDto, Guid, PagedAndSortedResultRequestDto,
    CreateAppointmentDto, UpdateAppointmentDto>, IAppointmentAppService
{
    private readonly AppointmentAvailabilityChecker _availability;
    private readonly HospitalManagmentDbContext _db;

    public AppointmentAppService(
        IRepository<Appointment, Guid> repository,
        AppointmentAvailabilityChecker availability,
        HospitalManagmentDbContext db)
        : base(repository)
    {
        _availability = availability;
        _db = db;
    }

    public override async Task<AppointmentDto> CreateAsync(CreateAppointmentDto input)
    {
        if (!await _availability.IsAvailableAsync(input.DoctorId, input.StartTime, input.EndTime))
            throw new UserFriendlyException("Seçilen zaman aralığında randevu çakışması var.");

        var entity = new Appointment(GuidGenerator.Create(), input.DoctorId, input.PatientId, input.StartTime, input.EndTime, input.Notes);
        await Repository.InsertAsync(entity, autoSave: true);
        return ObjectMapper.Map<Appointment, AppointmentDto>(entity);
    }

    public override async Task<AppointmentDto> UpdateAsync(Guid id, UpdateAppointmentDto input)
    {
        var current = await Repository.GetAsync(id);
        if (!await _availability.IsAvailableAsync(current.DoctorId, input.StartTime, input.EndTime, ignoreAppointmentId: id))
            throw new UserFriendlyException("Seçilen zaman aralığında randevu çakışması var.");

        var entity = new Appointment(id, current.DoctorId, current.PatientId, input.StartTime, input.EndTime, input.Notes);
        switch (input.Status)
        {
            case AppointmentStatus.Confirmed: entity.Confirm(); break;
            case AppointmentStatus.Completed: entity.Complete(); break;
            case AppointmentStatus.Cancelled: entity.Cancel(); break;
        }
        await Repository.UpdateAsync(entity, autoSave: true);
        return ObjectMapper.Map<Appointment, AppointmentDto>(entity);
    }

    public async Task<AppointmentDto> ConfirmAsync(Guid id)
    {
        var entity = await Repository.GetAsync(id);
        entity.Confirm();
        await Repository.UpdateAsync(entity, autoSave: true);
        return ObjectMapper.Map<Appointment, AppointmentDto>(entity);
    }

    public async Task<AppointmentDto> CompleteAsync(Guid id)
    {
        var entity = await Repository.GetAsync(id);
        entity.Complete();
        await Repository.UpdateAsync(entity, autoSave: true);
        return ObjectMapper.Map<Appointment, AppointmentDto>(entity);
    }

    public async Task<AppointmentDto> CancelAsync(Guid id)
    {
        var entity = await Repository.GetAsync(id);
        entity.Cancel();
        await Repository.UpdateAsync(entity, autoSave: true);
        return ObjectMapper.Map<Appointment, AppointmentDto>(entity);
    }

    public async Task<PagedResultDto<AppointmentDto>> GetListForDoctorAsync(Guid doctorId, DateTime? from = null, DateTime? to = null)
    {
        var query = _db.Appointments.AsNoTracking().Where(a => a.DoctorId == doctorId);
        if (from != null) query = query.Where(a => a.StartTime >= from);
        if (to != null) query = query.Where(a => a.StartTime < to);

        var total = await query.CountAsync();
        var items = await query.OrderBy(a => a.StartTime).Take(100).ToListAsync();
        var dtos = items.Select(ObjectMapper.Map<Appointment, AppointmentDto>).ToList();
        return new PagedResultDto<AppointmentDto>(total, dtos);
    }

    public async Task<PagedResultDto<AppointmentDto>> GetListForPatientAsync(Guid patientId, DateTime? from = null, DateTime? to = null)
    {
        var query = _db.Appointments.AsNoTracking().Where(a => a.PatientId == patientId);
        if (from != null) query = query.Where(a => a.StartTime >= from);
        if (to != null) query = query.Where(a => a.StartTime < to);

        var total = await query.CountAsync();
        var items = await query.OrderBy(a => a.StartTime).Take(100).ToListAsync();
        var dtos = items.Select(ObjectMapper.Map<Appointment, AppointmentDto>).ToList();
        return new PagedResultDto<AppointmentDto>(total, dtos);
    }
}