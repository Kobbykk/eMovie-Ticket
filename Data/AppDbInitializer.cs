using eMovie_Ticket.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace eMovie_Ticket.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                
                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "https://tse4.mm.bing.net/th?id=OIP.WHDK-ddFKt576GsniIq9IQHaF4&pid=Api&P=0&h=180",
                            Description = "This is the description for the first Cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "https://tse4.mm.bing.net/th?id=OIP.qLD_iwr08OVBFz3_5sCcQAHaFc&pid=Api&P=0&h=180",
                            Description = "This is the description for the Second Cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "https://tse1.mm.bing.net/th?id=OIP.C_MlqniGTjgZsLuKpvPUrQHaHa&pid=Api&P=0&h=180",
                            Description = "This is the description for the third Cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "https://tse3.mm.bing.net/th?id=OIP.to9_meHNVu5C9P8wCSsJVQAAAA&pid=Api&P=0&h=180",
                            Description = "This is the description for the fourth Cinema"
                        }

                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Will Smith",
                            Bio = "This is the Bio of the First actor",
                            ProfilePictureURL = "https://tse3.mm.bing.net/th?id=OIP.dAcr1vqqGXnb57EAGn3I8gAAAA&pid=Api&P=0&h=180"
                        },
                        new Actor()
                        {
                            FullName = "Dwayne Johhnson",
                            Bio = "This is the Bio of the Second actor",
                            ProfilePictureURL = "https://tse2.mm.bing.net/th?id=OIP.3YuLK7SAvXvJJ0ZYGrP_XgHaIl&pid=Api&P=0&h=180"
                        },
                        new Actor()
                        {
                            FullName = "Ryan Reynolds",
                            Bio = "This is the Bio of the Third actor",
                            ProfilePictureURL = "https://tse2.mm.bing.net/th?id=OIP.49zjtgSBwNeQdPmF2rQqIwHaIX&pid=Api&P=0&h=180"
                        },
                        new Actor()
                        {
                            FullName = "Angelina Jolie",
                            Bio = "This is the Bio of the Fourth actor",
                            ProfilePictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQxJtnlX6Iafft6ao1gI474t6_8UPGamkFoHA&usqp=CAU"
                        },
                        new Actor()
                        {
                            FullName = "Jennifer Aniston",
                            Bio = "This is the Bio of the Fourth actor",
                            ProfilePictureURL = "https://tse1.mm.bing.net/th?id=OIP.VbWslvgArB-DiEdvqdTn2QHaKA&pid=Api&P=0&h=180"
                        },
                         new Actor()
                        {
                            FullName = "Scarlett Johansson",
                            Bio = "This is the Bio of the Fourth actor",
                            ProfilePictureURL = "https://cdn.acidcow.com/pics/20131007/empires_list_of_the_sexiest_movie_stars_of_all_time_49.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the Bio of the First Producer",
                            ProfilePictureURL = "https://tse1.mm.bing.net/th?id=OIP.dDhPB2iCtvAv9vB0c5Sy7QAAAA&pid=Api&P=0&h=180"
                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "This is the Bio of the Second Producer",
                            ProfilePictureURL = "https://tse4.mm.bing.net/th?id=OIP.SvAyg0nOxpa6RKkv1cKvbQHaEU&pid=Api&P=0&h=180"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "This is the Bio of the Third Producer",
                            ProfilePictureURL = "https://tse1.mm.bing.net/th?id=OIP.OSRalyWDSsXlzx93FkmahgHaEo&pid=Api&P=0&h=180"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Bio = "This is the Bio of the Fourth Producer",
                            ProfilePictureURL = "https://tse4.mm.bing.net/th?id=OIP.ca_100ZmCEYTETjI9EQm1AHaE7&pid=Api&P=0&h=180"
                        }

                    });
                    context.SaveChanges();
                }

                //Movies
                if (!(context.Actors_Movies.Any()))
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "The Godfather",
                            Description = "This is the Godfather description",
                            Prize = 50.00,
                            ImageURL = "https://tse1.mm.bing.net/th?id=OIP.TmCmz3-dar0whKoqf5RfDQHaHa&pid=Api&P=0&h=180",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = Enums.MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "The Dark Knight",
                            Description = "This is The Dark Knight description",
                            Prize = 19.99,
                            ImageURL = "https://tse4.mm.bing.net/th?id=OIP.NN9rKH-vZbFgtH4FuoW7OwHaLH&pid=Api&P=0&h=180",
                            StartDate = DateTime.Now.AddDays(5),
                            EndDate = DateTime.Now.AddDays(1),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = Enums.MovieCategory.Action
                        },

                        new Movie()
                        {
                            Name = "Spider-Man",
                            Description = "This is the Amazing Spider-Man description",
                            Prize = 60.00,
                            ImageURL = "https://tse2.mm.bing.net/th?id=OIP.0n_KH2FBvoYlAKmx67GydAHaGx&pid=Api&P=0&h=180",
                            StartDate = DateTime.Now.AddDays(7),
                            EndDate = DateTime.Now.AddDays(2),
                            CinemaId = 2,
                            ProducerId = 4,
                            MovieCategory = Enums.MovieCategory.Adventure
                        },
                        new Movie()
                        {
                            Name = "The Matrix",
                            Description = "This is The Matrix description",
                            Prize = 24.00,
                            ImageURL = "https://tse3.mm.bing.net/th?id=OIP.mCr3x90hubrByxx2xp21EwHaLH&pid=Api&P=0&h=180",
                            StartDate = DateTime.Now.AddDays(10),
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 3,
                            ProducerId = 1,
                            MovieCategory = Enums.MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Inception",
                            Description = "This is the Inception description",
                            Prize = 30.00,
                            ImageURL = "https://tse4.mm.bing.net/th?id=OIP.Vg7gE_hwMujcoiqNbwekmAHaF7&pid=Api&P=0&h=180",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 4,
                            ProducerId = 2,
                            MovieCategory = Enums.MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }

                //Actors_ Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        }
                    });
                    context.SaveChanges();
                }
            }
           

        }
    }
}
