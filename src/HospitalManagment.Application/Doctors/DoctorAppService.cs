using HospitalManagment.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace HospitalManagement.Doctors;

public class DoctorAppService : CrudAppService<
    Doctor, DoctorDto, Guid, PagedAndSortedResultRequestDto,
    CreateUpdateDoctorDto>, IDoctorAppService
{
    private readonly HospitalManagmentDbContext _db;

    public DoctorAppService(IRepository<Doctor, Guid> repository, HospitalManagmentDbContext db) : base(repository)
    {
        _db = db;
    }

    public async Task SetAvailabilityNotesAsync(Guid id, string? notes)
    {
        var entity = await Repository.GetAsync(id);
        entity.SetAvailabilityNotes(notes);
        await Repository.UpdateAsync(entity, autoSave: true);
    }

    public async Task<int> GetTodayAppointmentCountAsync(Guid doctorId, DateTime today)
    {
        var start = today.Date;
        var end = start.AddDays(1);
        return await _db.Appointments.CountAsync(a => a.DoctorId == doctorId && a.StartTime >= start && a.StartTime < end && a.Status != Appointments.AppointmentStatus.Cancelled);
    }
}