using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace UserManagementAPI.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? UserName { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public string? Password { get; set; }
    }

    public class CreateUserRequest
    {
        [Required]
        public string? UserName { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public string? Password { get; set; }
    }
    
    public class GetUsersResponse
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
