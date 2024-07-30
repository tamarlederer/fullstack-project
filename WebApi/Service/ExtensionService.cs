using Common.Dto;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Repository.Entities;
using Repository.Interfaces;
using Repository.Repositories;
using Service.Interfaces;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    //1- מחלקה סטטית
    public static class ExtensionService
    {
        public static IServiceCollection AddService(this IServiceCollection services)
        {
            services.AddRepository();
            services.AddScoped<IService<UserDto>, UserService>();
            services.AddScoped<IService<DoctorDto>, DoctorService>();
            services.AddScoped<IService<AppointmentDto>, AppointmentService>();
            services.AddScoped<IService<CategoryDto>, CategoryService>();
            services.AddAutoMapper(typeof(MapperProfile));
            return services;
        }
        
    }
}
