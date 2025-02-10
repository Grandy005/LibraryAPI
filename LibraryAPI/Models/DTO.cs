namespace LibraryAPI.Models
{
    public record UpdateBookDTO(string Title, string Author, int PublishedYear, string Genre, decimal Price);
    public record AddBookDTO(string Title, string Author, int PublishedYear, string Genre, decimal Price);

}
