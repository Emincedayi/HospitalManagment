using HospitalManagment.Samples;
using Xunit;

namespace HospitalManagment.EntityFrameworkCore.Applications;

[Collection(HospitalManagmentTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<HospitalManagmentEntityFrameworkCoreTestModule>
{

}
