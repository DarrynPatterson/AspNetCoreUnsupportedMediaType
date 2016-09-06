# AspNetCoreUnsupportedMediaType

The [AspNetCoreUnsupportedMediaType package](https://www.nuget.org/packages/AspNetCoreUnsupportedMediaType/) is an ASP.NET Core solution which requires all http requests to have the 'Content-Type' header set to 'application/json'.

[![NuGet](https://img.shields.io/nuget/v/AspNetCoreUnsupportedMediaType.svg?maxAge=259200)](https://www.nuget.org/packages/AspNetCoreUnsupportedMediaType/) 

**NuGet install:**

Install-Package AspNetCoreUnsupportedMediaType

**Startup.cs code:**

    public void ConfigureServices(IServiceCollection services)
    {
		services.AddMvc()
				.AddMvcOptions(options =>
				{
					options.Filters.Add(typeof(UnsupportedMediaTypeResultFilter));
					options.Filters.Add(typeof(ValidateUnsupportedMediaTypeFilterAttribute));
				});
	}