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
                        Datedesortie = DateTime.Parse("1989-2-12"),
                        Genre = "Action Aventure",
                        Phase = "1",
                        Note = "8/10"
                    },

                    new Movie
                    {
                        Titre = "L'incroyable Hulk ",
                        Datedesortie = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Phase = "1",
                        Note = "8/10"
                    },

                    new Movie
                    {
                        Titre = "Ghostbusters 2",
                        Datedesortie = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Phase ="1" ,
                        Note = "9/10"
                    },

                    new Movie
                    {
                        Titre = "Rio Bravo",
                        Datedesortie = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Phase ="1",
                        Note = "8/10"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}