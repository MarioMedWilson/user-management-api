using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserManagementAPI.Data;
using UserManagementAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UserManagementAPI.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetUsersResponse>>> GetUsers()
        {
            var users = await _context.Users
                .Select(u => new GetUsersResponse
                {
                    Id = u.Id,
                    UserName = u.UserName,
                    FirstName = u.FirstName,
                    LastName = u.LastName
                })
                .ToListAsync();
            return Ok(users);
        }

        [HttpPost]
        public async Task<ActionResult<CreateUserRequest>> CreateUser(CreateUserRequest user)
        {
          var existingUser = await _context.Users.AnyAsync(u => u.UserName == user.UserName);
          if (existingUser)
          {
              return BadRequest(new { message = "Username is already taken." });
          }
          user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
          var newUser = new User
          {
              UserName = user.UserName,
              FirstName = user.FirstName,
              LastName = user.LastName,
              Password = user.Password
          };
          _context.Users.Add(newUser);
          await _context.SaveChangesAsync();
          return CreatedAtAction(nameof(GetUsers), 
          new { id = newUser.Id },
          new { 
            message = "User created successfully.",
            userId = newUser.Id
          });
        }
    }
}
