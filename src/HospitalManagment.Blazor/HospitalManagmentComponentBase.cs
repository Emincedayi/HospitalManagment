using HospitalManagment.Localization;
using Volo.Abp.AspNetCore.Components;

namespace HospitalManagment.Blazor;

public abstract class HospitalManagmentComponentBase : AbpComponentBase
{
    protected HospitalManagmentComponentBase()
    {
        LocalizationResource = typeof(HospitalManagmentResource);
    }
}
