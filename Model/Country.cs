namespace PokemonReviewApp.Model
{
    public class Country
    {
        public int ID { get; set; }
        public string MyProperty { get; set; }
        public ICollection<Owner> Owners { get; set; }
    }
}
