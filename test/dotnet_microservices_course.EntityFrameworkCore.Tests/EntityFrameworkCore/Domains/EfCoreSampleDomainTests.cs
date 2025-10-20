using dotnet_microservices_course.Samples;
using Xunit;

namespace dotnet_microservices_course.EntityFrameworkCore.Domains;

[Collection(dotnet_microservices_courseTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<dotnet_microservices_courseEntityFrameworkCoreTestModule>
{

}
