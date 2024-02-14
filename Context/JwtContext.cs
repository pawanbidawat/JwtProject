using JwtProject.Models;
using Microsoft.EntityFrameworkCore;

namespace JwtProject.Context
{
    public class JwtContext:DbContext
    {
        public JwtContext(DbContextOptions<JwtContext> option):base(option)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }

    }
}
