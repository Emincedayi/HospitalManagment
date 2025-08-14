using HospitalManagment.Samples;
using Xunit;

namespace HospitalManagment.EntityFrameworkCore.Domains;

[Collection(HospitalManagmentTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<HospitalManagmentEntityFrameworkCoreTestModule>
{

}
