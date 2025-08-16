using HospitalManagment.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace HospitalManagement.Appointments;

public class AppointmentAvailabilityChecker : ITransientDependency
{
    private readonly HospitalManagmentDbContext _db;

    public AppointmentAvailabilityChecker(HospitalManagmentDbContext db)
    {
        _db = db;
    }

    public async Task<bool> IsAvailableAsync(Guid doctorId, DateTime startTime, DateTime endTime, Guid? ignoreAppointmentId = null)
    {
        if (endTime <= startTime) return false;

        return !await _db.Appointments.AnyAsync(a =>
            a.DoctorId == doctorId &&
            a.Status != AppointmentStatus.Cancelled &&
            (ignoreAppointmentId == null || a.Id != ignoreAppointmentId.Value) &&
            a.StartTime < endTime && startTime < a.EndTime
        );
    }
}