using AutoMapper;
using LibraryBLL.Services;
using LibraryDAL.Infrastracture;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryBLL.Infrastructure
{
   public  class BussineslogicDIConfiguration
    {
        public  static void ConfigureteServices(IServiceCollection collection)
        {
            DataAccessLaerDIConfigurator.ConfigureServices(collection);
            collection.AddScoped<IAuthorService, AuthorService>();
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MapperConfigurator());
            });
           // collection.AddSingleton<IMapper>(mapperConfiguration.);
        }
    }
}
