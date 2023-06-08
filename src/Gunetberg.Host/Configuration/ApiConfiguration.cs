﻿using Gunetberg.Api.Converter;
using Gunetberg.Application;
using Gunetberg.Client.Token;
using Gunetberg.Port.Input;
using Gunetberg.Port.Output;
using Gunetberg.Port.Output.Repository;
using Gunetberg.Repository;

namespace Gunetberg.Host.Configuration
{
    public static class ApiConfiguration
    {
        public static IServiceCollection AddAppConfiguration(this IServiceCollection services)
        {
            //Repositories
            services.AddTransient<IAuthorizationRepository, AuthorizationRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IPostRepository, PostRepository>();

            //Clients
            services.AddTransient<ITokenClient, TokenClient>();

            //Services
            services.AddTransient<IAuthorizationService, AuthorizationService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IPostService, PostService>();
            services.AddTransient<PostApiConverter>();
            return services;
        }
    }
}