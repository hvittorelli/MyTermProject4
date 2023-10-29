using System;
using System.ComponentModel.DataAnnotations;

namespace MyTermProject.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

    }
}
