using AutoMapper;
using CRUD.Application.Automapper.Corridas;
using Microsoft.Extensions.DependencyInjection;

namespace CRUD.Application.Automapper
{
    public class AutoMapperConfig
    {
        public static void Configuration(IServiceCollection services)
        {
            var mapperconfig = new MapperConfiguration(config =>
            {
                config.AddCorrida<CadastroCorrida>();
            });
            services.AddSingleton(mapperconfig.CreateMapper());
        }
    }
}
