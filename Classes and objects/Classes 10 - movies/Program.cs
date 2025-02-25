using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_10___movies
{
    internal class Program
    {
        public static void MostPopular(Site s1, Site s2)
        {
            Movies popular = s1.MostWatchedMovie();

            s2.AddMovie(popular);
        }
        static void Main(string[] args)
        {
            Site site = new Site();
            for (int i = 0; i < 9; i++) 
            {
                Console.WriteLine("Please choose the method of entering the information of movie number {0}, 1 or 2?", i);
                int num = int.Parse(Console.ReadLine());
                if(num == 1)
                {
                    Console.WriteLine("Please enter the movie's name");
                    string name = Console.ReadLine();

                    Console.WriteLine("Please enter the genre of the movie");
                    string genre = Console.ReadLine();

                    Movies movie = new Movies(name, genre);
                    site.AddMovie(movie);
                }

                if(num == 2) 
                {
                    Console.WriteLine("Please enter the movie's name");
                    string name = Console.ReadLine();

                    Console.WriteLine("Please enter the genre of the movie");
                    string genre = Console.ReadLine();

                    Console.WriteLine("Please enter the release year of the movie");
                    int year = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter the number of views of the movie");
                    int views = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter the number of likes of the movie");
                    int likes = int.Parse(Console.ReadLine());


                    Movies movie = new Movies(name, genre, year, views, likes);
                    site.AddMovie(movie);
                }
            }

            string[] movies2020 = site.GetMoviesFromYear(2020); 
            for(int i = 0; i < movies2020.Length; i++)
                Console.WriteLine(movies2020[i]);


        }
    }
}
