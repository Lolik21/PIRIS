using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace PirisWebApp
{
    public static class AutoMapperConfigurator
    {
        public static void ConfigureAutoMapper(this IServiceCollection collection)
        {
            var profiles = Assembly.GetExecutingAssembly().GetTypes().Where(t => typeof(Profile).IsAssignableFrom(t)).ToList();
            Mapper.Initialize(
                mp =>
                {
                    var mapperConfiguration = new MapperConfiguration(cfg => cfg.AddProfiles(profiles));
                    var mapper = mapperConfiguration.CreateMapper();
                    collection.AddSingleton(mapper);
                });
        }
    }
}
