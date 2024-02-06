using AuthenticationAuthorizationConcepts.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationAuthorizationConcepts.Infrastructure.Data
{
    public class DataBaseContext : IdentityDbContext
    {
        public DataBaseContext(DbContextOptions dbContextOptions) : base()
        { 
        }

        public DbSet<User> Users { get; set; }
    }
}
