﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System.IO;

namespace Digipolis.Auth.UnitTests.Startup
{
    public class AddAuthFromJsonTests : AddAuthBaseTests
    {
        public AddAuthFromJsonTests()
        {
            var basePath = $"{Directory.GetCurrentDirectory()}/_TestData";

            Act = services =>
            {
                var mockHostingEnvironment = new Mock<IHostingEnvironment>();
                mockHostingEnvironment.Setup(h => h.EnvironmentName)
                    .Returns("");

                services.AddSingleton<IHostingEnvironment>(mockHostingEnvironment.Object);

                services.AddAuth(options =>
                {
                    options.BasePath = basePath;
                    options.FileName = @"authconfig.json";
                });
                services.AddOptions();
            };
        }
    }
}
