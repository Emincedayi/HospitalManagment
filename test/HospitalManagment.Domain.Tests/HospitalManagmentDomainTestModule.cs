using Volo.Abp.Modularity;

namespace HospitalManagment;

[DependsOn(
    typeof(HospitalManagmentDomainModule),
    typeof(HospitalManagmentTestBaseModule)
)]
public class HospitalManagmentDomainTestModule : AbpModule
{

}
