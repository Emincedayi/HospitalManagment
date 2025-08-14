using System.Threading.Tasks;

namespace HospitalManagment.Data;

public interface IHospitalManagmentDbSchemaMigrator
{
    Task MigrateAsync();
}
