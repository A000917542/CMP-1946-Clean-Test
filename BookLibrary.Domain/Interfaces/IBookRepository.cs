namespace BookLibrary.Domain.Interfaces;

using BookLibrary.Domain.Entities;

public interface IBookRepository
{
    public void Add(Book book);
    public IEnumerable<Book> GetAll();
    public Book? FindByTitle(string title);
    public void MarkAsRead(Guid id);
}