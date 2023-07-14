using System;
using CoreCodedChatbot.Config;
using Microsoft.Extensions.Configuration;

namespace CodedGhost.Config
{
    public class ConfigService : IConfigService
    {
        private IConfigurationRoot _configurationRoot;

        public ConfigService()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", true, true)
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", true, false)
                .AddEnvironmentVariables();

            _configurationRoot = builder.Build();
        }

        public T Get<T>(string configKey)
        {
            var configString = _configurationRoot[configKey];

            if (string.IsNullOrWhiteSpace(configString))
                return default(T);

            return (T) Convert.ChangeType(configString, typeof(T));
        }
    }
}