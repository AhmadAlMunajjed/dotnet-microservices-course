using Volo.Abp.Modularity;

namespace catalog;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class catalogDomainTestBase<TStartupModule> : catalogTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
