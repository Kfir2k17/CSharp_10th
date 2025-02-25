using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Classes_10___movies
{
    internal class Site
    {
        private Movies[] movies;
        private int amount;

        public Site()
        {
            movies = new Movies[1000];
            amount = 0;
        }

        public void AddMovie(Movies movie)
        {
            if (amount >= 1000)
                Console.WriteLine("error - not enough space");

            else
            {
                movies[amount] = movie;
                amount++;
            }
        }

        public void NoComedy3Stars()
        {
            for (int i = 0; i < amount; i++)
            {
                if (movies[i].Stars() == 3 && movies[i].GetGenre() != "Comedy")
                    Console.WriteLine(movies[i].GetName());
            }
        }

        public string[] GetMoviesFromYear(int year)
        {
            int counter = 0;

            for (int i = 0; i <= amount; i++)
            {
                if (movies[i].GetYear() == year || movies[i].GetYear() == year - 1)
                    counter++;
            }
            string[] movie_names = new string[counter];
            counter = 0;

            for (int i = 0; i <= amount; i++)
            {
                if (movies[i].GetYear() == year || movies[i].GetYear() == year - 1)
                {
                    movie_names[counter] = movies[i].GetName();
                    counter++;
                }
            }

            return movie_names;
        }

        public Movies Genrewith500views(string genre)
        {
            for (int i = 0; i < amount; i++)
            {
                if (movies[i].GetGenre() == genre && movies[i].GetViews() > 500)
                    return movies[i];
            }
            return null;
        }

        public bool UpdateLikes(string name, int likes)
        {
            for (int i = 0; i < amount; i++)
            {
                if (movies[i].GetName() == name)
                {
                    movies[i].SetLikes(movies[i].GetLikes() + likes);
                    return true;
                }
            }
            return false;
        }

        public Movies MostWatchedMovie()
        {
            int max_views = 0;
            Movies max_movie = null;

            for(int i = 0; i < amount; i++)
            {
                if (movies[i].GetViews() > max_views)
                {
                    max_views = movies[i].GetViews();
                    max_movie = movies[i];
                }
            }

            return max_movie;
        }

        public void DeleteMovie(string name)
        {
            for (int i = 0; i < amount; i++)
            {
                if (movies[i].GetName() == name)
                {
                    int place = 0;
                    for (int j = i; j < amount - 1 && movies[j + 1] != null; j++)
                    {
                        movies[i] = movies[i + 1];
                        place = j;
                    }
                    movies[place] = null;
                    break;
                }

            }
        }

        public void Delete3StarsMovies()
        {
            for(int i = 0; i < amount; i++) 
            {
                if (movies[i].Stars() == 3)
                    DeleteMovie(movies[i].GetName());
            }
        }
    }
}
