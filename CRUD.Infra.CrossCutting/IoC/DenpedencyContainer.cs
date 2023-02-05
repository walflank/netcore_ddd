using CRUD.Application.Interfaces;
using CRUD.Domain.Interfaces;
using CRUD.Infra.Data.Repositories;
using CRUD.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CRUD.Infra.CrossCutting.IoC
{
    public static class DenpedencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<ICompetidorService, CompetidorService>();
            services.AddScoped<ICompetidorRepository, CompetidorRepository>();

            services.AddScoped<IRaceService, RaceServices>();
            services.AddScoped<IRaceRepository, RaceRepository>();

            services.AddScoped<IPistaService, PistaServices>();
        }
    }

}
