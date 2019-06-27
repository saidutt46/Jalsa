using System;
using Jalsa.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Jalsa.Persistence.Contexts
{
    public class JalsaDbContext : IdentityDbContext<AppUser>
    {
        public JalsaDbContext(DbContextOptions options) : base(options) { }

        public DbSet<UserInfo> UserInfo { get; set; }
    }
}
