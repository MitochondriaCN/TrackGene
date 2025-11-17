using Microsoft.Extensions.Configuration;

namespace TrackGene.Configuration
{
#pragma warning disable CS8603, CS8618 // 可能返回 null 引用。
    public static class ConfigManager
    {
        private static AppConfig appConfig;

        public static void Initialize()
        {
            var configBuilder = new ConfigurationBuilder()
                                        .SetBasePath(Directory.GetCurrentDirectory())
                                        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfiguration configuration = configBuilder.Build();

            appConfig = configuration.Get<AppConfig>() ?? new AppConfig();
        }

        public static AppConfig GetAppConfig()
        {
            if (appConfig == null)
            {
                Initialize();
            }
            return appConfig;
        }
    }
#pragma warning restore CS8603, CS8618 // 可能返回 null 引用。
}