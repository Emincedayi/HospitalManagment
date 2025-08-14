using Volo.Abp.Settings;

namespace HospitalManagment.Settings;

public class HospitalManagmentSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(HospitalManagmentSettings.MySetting1));
    }
}
