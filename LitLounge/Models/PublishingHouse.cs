using System.ComponentModel.DataAnnotations;

namespace LitLounge.Models
{
    public class PublishingHouse
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
