﻿namespace Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Plot { get; set; }
        public string Poster { get; set; }
        public string Genre { get; set; }
        public string Type { get; set; }
        public int Year { get; set; }
        public string MpaaRating { get; set; }
        public string Runtime { get; set; }
        public string Language { get; set; }
        public string ImdbRating { get; set; }
        public string Website { get; set; }
        public string ImdbID { get; set; }

        public Movie()
        {

        }
        public Movie(string title, string plot, string poster, string genre, string type, int year, string mpaaRating, string runtime, string language, string imdbRating, string website, string imdbID)
        {
            Title = title;
            Plot = plot;
            Poster = poster;
            Genre = genre;
            Type = type;
            Year = year;
            MpaaRating = mpaaRating;
            Runtime = runtime;
            Language = language;
            ImdbRating = imdbRating;
            Website = website;
            ImdbID = imdbID;
        }
    }
}