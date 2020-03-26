using HelpMyStreet.Handlers.UserService;
using MediatR;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(HelpMyStreet.Startup))]
namespace HelpMyStreet
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddMediatR(typeof(FunctionAHandler).Assembly);
        }
    }
}