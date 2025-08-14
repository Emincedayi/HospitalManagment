using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace HospitalManagment.Data;

/* This is used if database provider does't define
 * IHospitalManagmentDbSchemaMigrator implementation.
 */
public class NullHospitalManagmentDbSchemaMigrator : IHospitalManagmentDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
