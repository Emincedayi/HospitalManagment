using HospitalManagment.Localization;
using Volo.Abp.Application.Services;

namespace HospitalManagment;

/* Inherit your application services from this class.
 */
public abstract class HospitalManagmentAppService : ApplicationService
{
    protected HospitalManagmentAppService()
    {
        LocalizationResource = typeof(HospitalManagmentResource);
    }
}
