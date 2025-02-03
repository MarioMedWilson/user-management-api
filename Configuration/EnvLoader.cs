using DotNetEnv;
using Microsoft.Extensions.Configuration;

namespace UserManagementAPI.Configuration
{
    public static class EnvLoader
    {
        public static IConfiguration Load()
        {
            Env.Load();

            var config = new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .Build();

            return config;
        }

        public static MySQLConfig GetDatabaseSettings()
        {
          var mysqlConfig = new MySQLConfig
          {
              Host = Env.GetString("DB_HOST"),
              Port = Env.GetString("DB_PORT"),
              Name = Env.GetString("DB_NAME"),
              User = Env.GetString("DB_USER"),
              Password = Env.GetString("DB_PASSWORD")
          };          
          return mysqlConfig;
        }

        public static JWTConfig GetJWTSettings()
        {
            return new JWTConfig
            {
                Secret = Env.GetString("JWT_SECRET")
            };
        }
    }
}
