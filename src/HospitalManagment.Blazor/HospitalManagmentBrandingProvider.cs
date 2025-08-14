using Microsoft.Extensions.Localization;
using HospitalManagment.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace HospitalManagment.Blazor;

[Dependency(ReplaceServices = true)]
public class HospitalManagmentBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<HospitalManagmentResource> _localizer;

    public HospitalManagmentBrandingProvider(IStringLocalizer<HospitalManagmentResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
