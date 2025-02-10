namespace LibraryAPI.Models
{
    public record UpdateBookDTO(string Title, string Author, int PublishedYear, string Genre, decimal Price);
}
