using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStock
{
    public class Movie
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public int Ratings { get; set; }
    }

    public class Program
    {
        // In your template this is already provided.
        public static List<Movie> MovieList = new List<Movie>();

        public void AddMovie(string movieDetails)
        {
            // Expected: Title,Artist,Genre,Ratings
            string[] stringArray = movieDetails.Split(',');
            Movie movie = new Movie();
            string Title = stringArray[0];
            string Artist = stringArray[1];
            string Genre = stringArray[2];
            int Ratings = Convert.ToInt32(stringArray[3]);

            movie.Title = Title;
            movie.Artist = Artist;
            movie.Genre = Genre;
            movie.Ratings = Ratings;

            MovieList.Add(movie);
            Console.WriteLine("Movie Added Successfully...");
            
        }

        public List<Movie> ViewMoviesByGenre(string genre)
        {
            // If your evaluation is strictly case-sensitive, replace OrdinalIgnoreCase with Ordinal
            genre = genre.ToLower();
            var fetched = MovieList.Where(item=> item.Genre.ToLower() == genre).ToList();

            return fetched;
            
        }

        public List<Movie> ViewMoviesByRatings()
        {

            return MovieList.OrderBy(item =>  item.Ratings).ToList();
           
        }

        public static void Main()
        {
            Program p = new Program();

            Console.Write("Enter number of movies: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter movie details (Title,Artist,Genre,Ratings):");
                p.AddMovie(Console.ReadLine());
            }

            Console.Write("Enter genre to search: ");
            string g = Console.ReadLine();

            var byGenre = p.ViewMoviesByGenre(g);
            if (byGenre.Count == 0)
            {
                Console.WriteLine($"No Movies found in genre '{g}'");
            }
            else
            {
                Console.WriteLine("Movies by Genre:");
                foreach (var m in byGenre)
                    Console.WriteLine($"{m.Title} | {m.Artist} | {m.Genre} | {m.Ratings}");
            }

            Console.WriteLine("Movies sorted by Ratings:");
            var sorted = p.ViewMoviesByRatings();
            foreach (var m in sorted)
                Console.WriteLine($"{m.Title} | {m.Artist} | {m.Genre} | {m.Ratings}");
        }
    }
}
