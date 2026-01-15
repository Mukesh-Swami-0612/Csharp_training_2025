using System;
using System.Collections.Generic;
using System.Linq;

public class Movie
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public string Genre { get; set; }
    public int Ratings { get; set; }

    public Movie() { }

    public Movie(string title, string artist, string genre, int ratings)
    {
        Title = title;
        Artist = artist;
        Genre = genre;
        Ratings = ratings;
    }
}

public class Program
{
    public static List<Movie> MovieList = new List<Movie>();

    public void AddMovie(string movieDetails)
    {
        string[] arr = movieDetails.Split(',');
        string title = arr[0].Trim();
        string artist = arr[1].Trim();
        string genre = arr[2].Trim();
        int ratings = int.Parse(arr[3].Trim());

        Movie m = new Movie(title, artist, genre, ratings);
        MovieList.Add(m);
    }

    public List<Movie> ViewMoviesByGenre(string genre)
    {
        return MovieList.Where(m => m.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public List<Movie> ViewMoviesByRatings()
    {
        return MovieList.OrderBy(m => m.Ratings).ToList();
    }

    public static void Main(string[] args)
    {
        Program p = new Program();

        Console.WriteLine("Enter the number of movies:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter movie details (Title,Artist,Genre,Ratings):");
        for (int i = 0; i < n; i++)
        {
            string details = Console.ReadLine();
            p.AddMovie(details);
        }

        Console.WriteLine("Enter the genre to search:");
        string searchGenre = Console.ReadLine();

        List<Movie> genreMovies = p.ViewMoviesByGenre(searchGenre);

        if (genreMovies.Count == 0)
        {
            Console.WriteLine($"No Movies found in genre '{searchGenre}'");
        }
        else
        {
            Console.WriteLine("Movies in the given genre:");
            foreach (Movie m in genreMovies)
            {
                Console.WriteLine($"{m.Title},{m.Artist},{m.Genre},{m.Ratings}");
            }
        }

        Console.WriteLine("Movies sorted by ratings:");
        List<Movie> ratingMovies = p.ViewMoviesByRatings();
        foreach (Movie m in ratingMovies)
        {
            Console.WriteLine($"{m.Title},{m.Artist},{m.Genre},{m.Ratings}");
        }
    }
}
