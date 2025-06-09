using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MRV.Domain.Abstractions;
using MRV.Infrastructure.Context;
using MRV.Infrastructure.Repositories;

namespace MRV.CrossCutting.AppDependencies
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var sqlConnection = configuration.GetConnectionString("SqlConnection");

            services.AddDbContext<SqlDbContext>(options => options.UseSqlServer(sqlConnection));

            services.AddScoped<ILeadRepository, LeadRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            var handlers = AppDomain.CurrentDomain.Load("MRV.Application");
            services.AddMediatR(s => s.RegisterServicesFromAssemblies(handlers));

            return services;
        }
    }
}
