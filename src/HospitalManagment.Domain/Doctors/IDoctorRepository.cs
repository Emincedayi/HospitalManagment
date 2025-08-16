using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace HospitalManagement.Doctors
{
    public interface IDoctorRepository : IRepository<Doctor, Guid>
    {
        Task<Doctor> CreateAsync(Doctor doctor);
        Task DeleteAsync(Guid id);
    }
}
