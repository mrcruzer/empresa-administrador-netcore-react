using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.RuntimeSupport;
using static empresa_administrador_api.Startup;
using Amazon.Lambda.Serialization.Json;
//using Newtonsoft.Json;

namespace empresa_administrador_api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if(string.IsNullOrEmpty(Environment.GetEnvironmentVariable("AWS_LAMBDA_FUNCTION_NAME")))
            {
                CreateHostBuilder(args).Build().Run();
                //CreateWebHostBuilder(args).Build().Run();
            }
            else
            {
                var lambdaEntry = new LambdaFunction();
                var functionHandler = (Func<APIGatewayProxyRequest, ILambdaContext, Task<APIGatewayProxyResponse>>)(lambdaEntry.FunctionHandlerAsync);
                using (var handlerWrapper = HandlerWrapper.GetHandlerWrapper(functionHandler, new JsonSerializer()))
                using (var bootstrap = new LambdaBootstrap(handlerWrapper))
                {
                    bootstrap.RunAsync().Wait();
                }
            }


        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
