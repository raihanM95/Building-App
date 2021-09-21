using Building.BLL.IServices;
using Building.BLL.Services;
using Building.DAL;
using Building.DAL.IRepositories;
using Building.DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Building.API.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            // Repository 
            services.AddTransient<IReadingRepository, ReadingRepository>();
            services.AddTransient<IBuildingRepository, BuildingRepository>();
            services.AddTransient<IDataFieldRepository, DataFieldRepository>();
            services.AddTransient<IObjectRepository, ObjectRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            // Service
            services.AddTransient<IReadingService, ReadingService>();
            services.AddTransient<IDropdownLoadService, DropdownLoadService>();
        }
    }
}
