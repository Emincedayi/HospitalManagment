using Volo.Abp.Modularity;

namespace HospitalManagment;

[DependsOn(
    typeof(HospitalManagmentApplicationModule),
    typeof(HospitalManagmentDomainTestModule)
)]
public class HospitalManagmentApplicationTestModule : AbpModule
{

}
