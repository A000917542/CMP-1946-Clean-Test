namespace BookLibrary.Application.UseCases;

using BookLibrary.Domain.Entities;
using BookLibrary.Domain.Interfaces;

public class AddBook
{
    private readonly IBookRepository _bookRepository;

    public AddBook(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public void Execute(string title, string author, int year)
    {
        var book = new Book { Title = title, Author = author, Year = year };
        _bookRepository.Add(book);
    }
}