namespace PokemonReviewApp.Model
{
    public class Pokemon
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gym { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<PokemonOwner> PokemonOwners { get; set; }
        public ICollection<PokemonCategory> PokemonCategories { get; set; }

    }
}
