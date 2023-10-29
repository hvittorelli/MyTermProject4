using System;
using System.ComponentModel.DataAnnotations;

namespace MyTermProject.Models
{
    public enum Format
    {
        Hardcover,
        Paperback,
        Audio,
        Digital,
        Other
    }
    public class Books
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Book Title")]
        [StringLength(100, ErrorMessage = "Please enter the Title of the book using 100 characters or less.")]
        public string? BookTitle { get; set; }

        [Required]
        [Display(Name = "Author")]
        [StringLength(50, ErrorMessage = "Please enter the Author's name using 50 characters or less")]
        public string? AuthorName { get; set; }


        [StringLength(30, ErrorMessage = "Genre should have 30 characters or less.")]
        public Genre? Genre { get; set; } = null!;
        public int GenreId { get; set; }

        [Display(Name = "Format")]
        public Format? BookFormat { get; set; }
    }
}
