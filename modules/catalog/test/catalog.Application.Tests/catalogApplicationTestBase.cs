using Volo.Abp.Modularity;

namespace catalog;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class catalogApplicationTestBase<TStartupModule> : catalogTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
