using Stella_Commerce.Model;
using Microsoft.EntityFrameworkCore;

namespace Stella_Commerce
{
    public class ProfileContext : DbContext
    {
        public DbSet<Profile> Profiles { get; set; }
        private string DatabasePath { get; }

        public ProfileContext(DbContextOptions<ProfileContext> dbContextOptions) : base(dbContextOptions)
        {
            DatabasePath = "./profiles.db";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite($"DataSource={DatabasePath}");
    }
}
