using Microsoft.AspNetCore.Builder;
using dotnet_microservices_course;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("dotnet_microservices_course.Web.csproj"); 
await builder.RunAbpModuleAsync<dotnet_microservices_courseWebTestModule>(applicationName: "dotnet_microservices_course.Web");

public partial class Program
{
}
