using Xunit;

namespace HospitalManagment.EntityFrameworkCore;

[CollectionDefinition(HospitalManagmentTestConsts.CollectionDefinitionName)]
public class HospitalManagmentEntityFrameworkCoreCollection : ICollectionFixture<HospitalManagmentEntityFrameworkCoreFixture>
{

}
