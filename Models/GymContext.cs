using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ThunderGym.Models
{
    public class GymContext : DbContext
    {
        public GymContext(DbContextOptions<GymContext> options)
        : base(options)
        { }

        public DbSet<User>? User { get; set; }
        public DbSet<Member>? Member { get; set; }
        public DbSet<Trainer>? Trainer { get; set; }
        public DbSet<Admin>? Admin { get; set; }
        public DbSet<Class>? Class { get; set; }
        public DbSet<Membership>? Membership { get; set; }
        public DbSet<Payment>? Payments { get; set; }

    }
}
