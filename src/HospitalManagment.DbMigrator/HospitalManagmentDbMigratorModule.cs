using HospitalManagment.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace HospitalManagment.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(HospitalManagmentEntityFrameworkCoreModule),
    typeof(HospitalManagmentApplicationContractsModule)
)]
public class HospitalManagmentDbMigratorModule : AbpModule
{
}
