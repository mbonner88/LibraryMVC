using Microsoft.AspNetCore.Mvc.Rendering;

namespace LibraryMVC.Models
{
    public class BookViewModel
    {
        public List<Book>? Books { get; set; }
        public SelectList? Genres { get; set; }
        public string? BookGenre { get; set; }
        public string? TitleSearchString { get; set;}
        public string? AuthorSearchString { get; set; }

    }
}
