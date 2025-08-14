using Volo.Abp.Modularity;

namespace HospitalManagment;

public abstract class HospitalManagmentApplicationTestBase<TStartupModule> : HospitalManagmentTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
