using HospitalManagment.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace HospitalManagment.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class HospitalManagmentController : AbpControllerBase
{
    protected HospitalManagmentController()
    {
        LocalizationResource = typeof(HospitalManagmentResource);
    }
}
