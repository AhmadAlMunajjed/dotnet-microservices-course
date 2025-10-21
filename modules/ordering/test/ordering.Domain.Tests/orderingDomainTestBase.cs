using Volo.Abp.Modularity;

namespace ordering;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class orderingDomainTestBase<TStartupModule> : orderingTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
