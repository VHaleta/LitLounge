using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace LitLounge.Models
{
    public class Book
    {
        [Key]
        public string Isbn { get; set; }
        public string Name { get; set; }
        public int Pages { get; set; }
        public int PublishingYear { get; set; }
        [AllowNull]
        public string Description { get; set; }
        public int GenreId { get; set; }
        public int AuthorId { get; set; }
        public int PublishingHouseId { get; set; }
        public Genre Genre { get; set; }
        public Author Author { get; set; }
        public PublishingHouse PublishingHouse { get; set; }
    }
}
