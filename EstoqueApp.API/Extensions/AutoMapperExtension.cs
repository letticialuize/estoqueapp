﻿using MediatR;

namespace EstoqueApp.API.Extensions
{
    public static class AutoMapperExtension
    {
        public static IServiceCollection AddAutoMapperProfiles(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            return services;
        }
    }
}
