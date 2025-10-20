using Volo.Abp.Settings;

namespace dotnet_microservices_course.Settings;

public class dotnet_microservices_courseSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(dotnet_microservices_courseSettings.MySetting1));
    }
}
