using Volo.Abp.Modularity;

namespace HospitalManagment;

/* Inherit from this class for your domain layer tests. */
public abstract class HospitalManagmentDomainTestBase<TStartupModule> : HospitalManagmentTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
