using Microsoft.EntityFrameworkCore;
using PokemonReviewApp.Model;
namespace PokemonReviewApp.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { 
        }

        public DbSet<Category>Categories { get; set; }

        public DbSet<Country> Countries { get; set; }

    }
}
