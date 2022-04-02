using LibraryDAL.Context;
using LibraryDAL.Entities;
using LibraryDAL.repo;
using LibraryDAL.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDAL.Infrastracture
{
    public class DataAccessLaerDIConfigurator
    {
        public static void ConfigureServices(IServiceCollection servisecollection)
        {
            servisecollection.AddSingleton<LibraryContext>();
            servisecollection.AddTransient<IRepository<Author>, AutorRepository>();

        }
    }
}
