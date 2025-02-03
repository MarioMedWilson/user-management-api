using Microsoft.EntityFrameworkCore;
using UserManagementAPI.Configuration;

namespace UserManagementAPI.Data
{
    public static class DatabaseConfig
    {
        public static void ConfigureDatabase(IServiceCollection services)
        {
            // Load database settings
            var dbSettings = EnvLoader.GetDatabaseSettings();

            var connectionString = $"Server={dbSettings.Host};Database={dbSettings.Name};User={dbSettings.User};Password={dbSettings.Password};Port={dbSettings.Port};";

            // Register MySQL Database Context
            services.AddDbContext<AppDbContext>(options =>
                options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 32))));
        }
    }
}
