using AutoMapper;
using HelpMyStreet.Core.Interfaces.Repositories;
using HelpMyStreet.Handlers;
using HelpMyStreet.Mappers;
using HelpMyStreet.Repo;
using MediatR;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

[assembly: FunctionsStartup(typeof(HelpMyStreet.Startup))]
namespace HelpMyStreet
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddMediatR(typeof(FunctionAHandler).Assembly);
            builder.Services.AddAutoMapper(typeof(AddressDetailsProfile).Assembly);

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                   options.UseInMemoryDatabase(databaseName: "HelpMyStreet"));
            builder.Services.AddTransient<IRepository, Repository>();
        }
    }
}