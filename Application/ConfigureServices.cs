﻿using Application.Interfaces;
using Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICustomerService,CustomerService>();
            services.AddScoped<ISaleOrderService, SaleOrderService>();

            return services;
        }
    }
}
