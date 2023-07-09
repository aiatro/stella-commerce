using Stella_Commerce.Model;
using Microsoft.EntityFrameworkCore;

namespace Stella_Commerce
{
    public class ProfileContext : DbContext
    {
        private DbSet<Profile> Profiles { get; set; }
        private string DatabasePath { get; }

        public ProfileContext()
        {
            DatabasePath = "./profiles.db";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite($"DataSource={DatabasePath}");
    }
}
