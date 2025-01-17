namespace imdb.web.Models
{
    public class Category
    {
        public Category() { 
            
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }
}
