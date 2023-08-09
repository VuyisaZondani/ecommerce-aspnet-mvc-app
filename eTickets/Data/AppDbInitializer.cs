using eTickets.Data.Enums;
using eTickets.Models;

namespace eTickets.Data
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
                            Name = "Ster-Kinekor",
                            Logo = "https://cdn.24.co.za/files/Cms/General/d/6811/a361878bb9734ba19b5d899b2c4c4fd9.png",
                            Description = "This is the description of the first cinema"


                        },

                        new Cinema()
                        {
                            Name = "Nu-Metro",
                            Logo = "https://cdn.hyprop.co.za/image/2021/7/21/e24cc134-bb12-45fa-8fa6-34a6cee57e24/e1a3df85-576e-414a-a958-ddfe76247615.jpg?w=1120&h=630&webp",
                            Description = "This is the description of the second cinema"


                        },


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
                        Bio = "Will Smith, byname of Willard Carroll Smith, Jr., /n" +
                        " (born September 25, 1968, Philadelphia, Pennsylvania, U.S.) /n" +
                        ", American actor and musician whose charisma and quick wit helped him transition from rap music to a successful career in acting.",
                        ProfilePictureURL = "https://cdn.britannica.com/66/103066-050-B89D5EAF/Will-Smith-actor-musician-2006.jpg"


                    },

                    new Actor()
                    {
                        FullName = "Al Pacino",
                        Bio = "Al Pacino, in full Alfredo James Pacino,/n" +
                        " (born April 25, 1940, New York, New York, U.S.),/n" +
                        " American actor best known for his intense, explosive acting style.",
                        ProfilePictureURL = "https://cdn.britannica.com/45/196745-050-66D0F975/Al-Pacino-Scarface-Brian-De-Palma.jpg"


                    },

                    new Actor()
                    {
                        FullName = "Denzel Washington",
                        Bio = "Denzel Washington, (born December 28, 1954, Mount Vernon, New York, U.S.), American actor celebrated for his engaging and powerful performances./n" +
                        " Throughout his career he was regularly praised by critics,/n" +
                        " and his consistent success at the box office helped to dispel the perception that African American actors could not draw mainstream white audiences.",
                        ProfilePictureURL = "https://cdn.britannica.com/25/190725-050-040595B1/Movie-still-Training-Day-Denzel-Washington-2001.jpg"

                    },


                    });
                }
                    context.SaveChanges();
                    //Producers
                    if (!context.Producers.Any())
                    {

                        context.Producers.AddRange(new List<Producer>()
                        {
                            new Producer()
                            {
                                FullName = "Brian De Palma",
                                Bio = "Brian De Palma, in full Brian Russell De Palma, De Palma sometimes spelled DePalma, (born September 11, 1940, Newark, New Jersey, U.S.),/n" +
                                " American motion-picture director and screenwriter best noted for his usually stylish,/n" +
                                " often graphic horror-suspense films that draw heavily on the work of director Alfred Hitchcock.",
                                ProfilePictureURL = "https://cdn.britannica.com/34/157034-050-142D9593/Brian-De-Palma-2006.jpg"

                            },

                            new Producer()
                            {
                                FullName = "John Davis",
                                Bio = "John Davis was born in Denver, Colorado, USA./n" +
                                " He is known for I, Robot (2004), Waterworld (1995) and Game Night (2018). He is married to Jordan Davis. They have three children.",
                                ProfilePictureURL = "https://images.mubicdn.net/images/cast_member/28902/cache-240793-1500958144/image-w856.jpg?size=240x"

                            },

                            new Producer()
                            {
                               FullName = "Antoine Fuqua",
                               Bio = "Antoine Fuqua is an American filmmaker, known for his work in the action and thriller genres./n" +
                               " He was originally known as a director of music videos, and made his film debut in 1998 with The Replacement Killers./n" +
                               " His critical breakthrough was the 2001 crime thriller Training Day.",
                               ProfilePictureURL = "https://variety.com/wp-content/uploads/2022/03/0040898403.original-e1647908496568.jpeg?w=1000&h=563&crop=1&resize=1000%2C563"

                            },


                        });
                        context.SaveChanges();
                    }
                        //Movies
                    if (!context.Movies.Any())
                    {
                        context.Movies.AddRange(new List<Movie>()
                        {
                            new Movie()
                            {
                                Name = "Scarface",
                                Description = "scarface",
                                Price = 10,
                                ImageUrl = "https://cdn.europosters.eu/image/1300/posters/scarface-say-hello-to-my-little-friend-i10924.jpg",
                                StartDate = DateTime.Now.AddDays(5),
                                EndDate = DateTime.Now.AddDays(10),
                                CinemaId = 1,
                                ProducerId = 1,
                                MovieCategory = Enums.MovieCategory.Action


                            },
                            new Movie()
                            {
                                Name = "I, Robot",
                                Description = "robots",
                                Price = 10,
                                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/3/3b/Movie_poster_i_robot.jpg/220px-Movie_poster_i_robot.jpg",
                                StartDate = DateTime.Now.AddDays(5),
                                EndDate = DateTime.Now.AddDays(10),
                                CinemaId = 1,
                                ProducerId = 2,
                                MovieCategory = Enums.MovieCategory.Action


                            },
                            new Movie()
                            {
                                Name = "Training Day",
                                Description = "training",
                                Price = 10,
                                ImageUrl = "https://cdn.britannica.com/16/77316-050-04120A9B/Denzel-Washington-Training-Day-2001.jpg",
                                StartDate = DateTime.Now.AddDays(5),
                                EndDate = DateTime.Now.AddDays(10),
                                CinemaId = 2,
                                ProducerId = 3,
                                MovieCategory = Enums.MovieCategory.Action


                            },




                    });
                            context.SaveChanges();

                    }
                    

                    if (!context.Actors_Movies.Any())
                    {
                        context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2                            },

                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 1
                        },

                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 3
                        }
                    }
                     );

                        context.SaveChanges();


                    }
                }

            }

        }
    }




            
        
    


