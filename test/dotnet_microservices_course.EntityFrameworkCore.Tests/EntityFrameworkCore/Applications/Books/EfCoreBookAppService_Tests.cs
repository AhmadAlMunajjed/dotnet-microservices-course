﻿using dotnet_microservices_course.Books;
using Xunit;

namespace dotnet_microservices_course.EntityFrameworkCore.Applications.Books;

[Collection(dotnet_microservices_courseTestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<dotnet_microservices_courseEntityFrameworkCoreTestModule>
{

}