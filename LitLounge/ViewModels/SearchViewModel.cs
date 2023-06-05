using LitLounge.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace LitLounge.ViewModels
{
    public class SearchViewModel
    {
        public string? BookName { get; set; }
        public string? Author { get; set; }
        public string? ISBN { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Value cannot be lover 0")]
        public int PagesFrom { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Value cannot be lover 0")]
        public int PagesTo { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Value cannot be lover 0")]
        public int YearFrom { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Value cannot be lover 0")]
        public int YearTo { get; set; }
        public string? Category { get; set; } = "Any";
        public List<Book> Books { get; set; } = new List<Book>();
    }
}
