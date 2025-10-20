using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace dotnet_microservices_course.Pages;

[Collection(dotnet_microservices_courseTestConsts.CollectionDefinitionName)]
public class Index_Tests : dotnet_microservices_courseWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
