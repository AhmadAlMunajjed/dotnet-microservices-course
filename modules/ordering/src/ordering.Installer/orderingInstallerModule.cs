using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace ordering;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class orderingInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<orderingInstallerModule>();
        });
    }
}
