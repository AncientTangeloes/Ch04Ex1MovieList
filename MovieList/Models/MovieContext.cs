using Microsoft.EntityFrameworkCore;

namespace MovieList.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext() { }
        
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = "A", Name = "Action" },
                new Genre { GenreId = "B", Name = "Biographical" },
                new Genre { GenreId = "C", Name = "Comedy" },
                new Genre { GenreId = "D", Name = "Drama" },
                new Genre { GenreId = "E", Name = "Experimental" },
                new Genre { GenreId = "F", Name = "Fantasy" },
                new Genre { GenreId = "G", Name = "Gothic" },
                new Genre { GenreId = "H", Name = "Horror" },
                new Genre { GenreId = "I", Name = "Historical" },
                new Genre { GenreId = "K", Name = "Kaiju" },
                new Genre { GenreId = "M", Name = "Musical" },
                new Genre { GenreId = "N", Name = "Noir" },
                new Genre { GenreId = "O", Name = "Documentary" },
                new Genre { GenreId = "P", Name = "Parody" },
                new Genre { GenreId = "R", Name = "RomCom" },
                new Genre { GenreId = "S", Name = "Scifi" },
                new Genre { GenreId = "T", Name = "Thriller" },
                new Genre { GenreId = "W", Name = "Western" }
            );
            
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    MovieId = 1,
                    Name = "Casablanca",
                    Year = 1942,
                    Rating = 5,
                    GenreId = "D"
                },
                new Movie
                {
                    MovieId = 2,
                    Name = "Wonder Woman",
                    Year = 2017,
                    Rating = 3,
                    GenreId = "A"
                },
                new Movie
                {
                    MovieId = 3,
                    Name = "Moonstruck",
                    Year = 1988,
                    Rating = 4,
                    GenreId = "R"
                }
            );
        }
    }
}
