using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Titre = "Iron Man",
                        Image="Iron-Man-2008.png.webp",
                        Datedesortie = DateTime.Parse("1989-2-12"),
                        Genre = "Action Aventure",
                        
                        Phase = "1",
                        Note = "8/10"
                    },

                    new Movie
                    {
                        Titre = "L'incroyable Hulk ",
                        Image="The-Incredible-Hulk-2008.png.webp",
                        Datedesortie = DateTime.Parse("1984-3-13"),
                        
                        Genre = "Action SF",
                        Phase = "1",
                        Note = "8/10"
                    },

                    new Movie
                    {
                        Titre = "Iron Man 2",
                        Image="Iron-Man-2-2010.png.webp",
                        Datedesortie = DateTime.Parse("1986-2-23"),
                        
                        Genre = "Action Aventure",
                        Phase ="1" ,
                        Note = "9/10"
                    },

                    new Movie
                    {
                        Titre = "Thor",
                        Image="Thor-2011.png",
                        Datedesortie = DateTime.Parse("1959-4-15"),
                        
                        Genre = "Action Aventure",
                        Phase ="1",
                        Note = "8/10"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}