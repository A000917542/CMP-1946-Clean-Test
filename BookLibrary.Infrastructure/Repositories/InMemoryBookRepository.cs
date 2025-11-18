namespace BookLibrary.Infrastructure.Repositories;

using System;
using System.Collections.Generic;
using BookLibrary.Domain.Entities;
using BookLibrary.Domain.Interfaces;

public class InMemoryBookRepository : IBookRepository
{
    private readonly List<Book> _books = new();
    public void Add(Book book)
    {
        _books.Add(book);
    }

    public Book? FindByTitle(string title)
    {
        return _books.Find((book) => book.Title.Contains(title));
    }

    public IEnumerable<Book> GetAll()
    {
        return _books;
    }

    public void MarkAsRead(Guid id)
    {
        var book = _books.Find((book) => book.Id == id);
        if (book != null) book.IsRead = true;
    }
}