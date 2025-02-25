    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_10___movies
{
    internal class Movies
    {
        private string name;
        private string genre;
        private int year;
        private int views;
        private int likes;

        public Movies(string name, string genre)
        {
            this.name = name;
            this.genre = genre;
            this.year = 2023;
            this.views = 0;
            this.likes = 0;
        }

        public Movies(string name, string genre, int year, int views, int likes)
        {
            this.name = name;
            this.genre = genre;
            this.year = year;
            this.views = views;
            this.likes = likes;
        }

        public string GetName() { return name; }
        public string GetGenre() { return genre; }
        public int GetYear() { return year; }
        public int GetViews() { return views; }
        public int GetLikes() { return likes; }
        public void SetName(string name) { this.name = name; }
        public void SetGenre(string genre) { this.genre = genre; }
        public void SetYear(int year) { this.year = year; }
        public void SetViews(int views) { this.views = views; }
        public void SetLikes(int likes) { this.likes = likes; }

        public int Stars()
        {
            if (views - (views * 0.2) <= likes)
                return 5;
            if (views - (views * 0.4) < likes)
                return 4;
            return 3;
        }
    }
}
