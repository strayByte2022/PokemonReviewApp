using Microsoft.EntityFrameworkCore;
using PokemonReviewApp.Model;
namespace PokemonReviewApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<PokemonCategory> PokemonCategories { get; set; }
        public DbSet<PokemonOwner> PokemonOwners { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PokemonCategory>()
             .HasKey(pc => new { pc.PokemonID, pc.CategoryID });

            modelBuilder.Entity<PokemonCategory>()
                .HasOne(p => new { p.Pokemon }).WithMany(pc => pc.Pokemon.PokemonCategories)
                .HasForeignKey(c => c.PokemonID);
            modelBuilder.Entity<PokemonCategory>()
                .HasOne(p => new { p.Category })
                .WithMany(pc => pc.Category.PokemonCategories)
                .HasForeignKey(c => c.CategoryID);
            modelBuilder.Entity<PokemonOwner>()
                .HasKey(pc => new { pc.PokemonID, pc.OwnerID });

            modelBuilder.Entity<PokemonOwner>()
                .HasOne(p => p.Pokemon)
                 .WithMany(pc => pc.PokemonOwners)
                  .HasForeignKey(p => p.PokemonID);
            modelBuilder.Entity<PokemonOwner>()
                    .HasOne(p => p.Owner)
                    .WithMany(pc => pc.PokemonOwners)
                    .HasForeignKey(c => c.OwnerID);

        }
    }
}
