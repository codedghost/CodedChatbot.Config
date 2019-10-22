using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace CoreCodedChatbot.Config
{
    public static class Package
    {
        public static IServiceCollection AddChatbotConfigService(this IServiceCollection services)
        {
            services.AddSingleton<IConfigService, ConfigService>();

            return services;
        }
    }
}
