using Microsoft.EntityFrameworkCore;

namespace AzurLaneLoreWiki.Data
{
    public class DB_WikiContentsContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DB_WikiContentsContext(IConfiguration configuration)
        {
            Configuration = configuration;
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Configuration.GetConnectionString("DB_WikiContents"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<EventCharacterMappings>().HasNoKey();
        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<CharacterQuote> CharacterQuotes { get; set; }
        public DbSet<EventCharacterMappings> EventCharacterMappings { get; set; }
    }
}
