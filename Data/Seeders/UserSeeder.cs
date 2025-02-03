using Microsoft.EntityFrameworkCore;
using UserManagementAPI.Models;

namespace UserManagementAPI.Data.Seeders
{
    public static class UserSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, FirstName = "John", LastName = "Doe", UserName = "john.doe", Password = BCrypt.Net.BCrypt.HashPassword("password") },
                new User { Id = 2, FirstName = "Jane", LastName = "Smith", UserName = "jane.smith", Password = BCrypt.Net.BCrypt.HashPassword("password") },
                new User { Id = 3, FirstName = "Alice", LastName = "Johnson", UserName = "alice.johnson", Password = BCrypt.Net.BCrypt.HashPassword("password") },
                new User { Id = 4, FirstName = "Bob", LastName = "Brown", UserName = "bob.brown", Password = BCrypt.Net.BCrypt.HashPassword("password") }
            );
        }
    }
}
