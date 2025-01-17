namespace imdb.web.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string Actors { get; set; }
        public string Plot { get; set; }
        public string Poster { get; set; }
        public string ImdbRating { get; set; }
        public string ImdbId { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
