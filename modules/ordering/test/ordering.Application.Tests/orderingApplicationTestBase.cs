using Volo.Abp.Modularity;

namespace ordering;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class orderingApplicationTestBase<TStartupModule> : orderingTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
