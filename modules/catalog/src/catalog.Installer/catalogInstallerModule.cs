using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace catalog;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class catalogInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<catalogInstallerModule>();
        });
    }
}
