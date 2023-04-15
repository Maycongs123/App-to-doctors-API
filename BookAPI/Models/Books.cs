﻿namespace BookAPI.Models
{
    public class Books
    {
        public int Id { get; set; }

        public string? Author { get; set; }

        public string? Description { get; set; }

        public string? Title { get; set; }

        //public string? Language { get; set; }

        //public string? TotalPages { get; set; }

        public DateTime Year { get; set; }

    }
}
