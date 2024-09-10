using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VeniumAPI
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<TestAPI> TestAPI { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Matchmaking> Matchmaking { get; set; }
        public DbSet<Elements> Elements { get; set; }
        public DbSet<Abilities> Abilities { get; set; }
        public DbSet<Pokemon> Pokemon { get; set; }
    }
}
