using System.Diagnostics.Contracts;

namespace BookLibrary.Domain.Entities;

public class Book
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = String.Empty;
    public string Author { get; set; } = String.Empty;
    public int Year { get; set; }
    public bool IsRead { get; set; } = false;
}
