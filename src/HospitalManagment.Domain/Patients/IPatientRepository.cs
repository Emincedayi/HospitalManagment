using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace HospitalManagement.Patients
{
    public interface IPatientRepository : IRepository<Patient, Guid>
    {
        Task<Patient> CreateAsync(Patient patient);
        Task DeleteAsync(Guid id);
    }
}
