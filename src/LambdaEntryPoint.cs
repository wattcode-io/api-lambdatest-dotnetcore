using System;
using Microsoft.AspNetCore.Hosting;
using Amazon.Lambda.AspNetCoreServer;

namespace Realvision.LambdaTestApi
{
    public class LambdaEntryPoint : APIGatewayProxyFunction
    {
        protected override void Init(IWebHostBuilder builder)
        {
            builder.UseStartup<Startup>();
        }
    }
}