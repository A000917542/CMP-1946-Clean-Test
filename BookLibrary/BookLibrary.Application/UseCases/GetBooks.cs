namespace BookLibrary.Application.UseCases;

using BookLibrary.Domain.Entities;
using BookLibrary.Domain.Interfaces;

public class GetBooks
{
    private readonly IBookRepository _bookRepository;

    public GetBooks(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public IEnumerable<Book> Execute()
    {
        return _bookRepository.GetAll();
    }
}