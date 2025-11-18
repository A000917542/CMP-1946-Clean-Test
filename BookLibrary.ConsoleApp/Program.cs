using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using BookLibrary.Domain.Entities;
using BookLibrary.Domain.Interfaces;
using BookLibrary.Infrastructure.Repositories;
using BookLibrary.Application.UseCases;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddSingleton<IBookRepository, InMemoryBookRepository>();
builder.Services.AddScoped<GetBooks>();

using IHost app = builder.Build();

AddBook addBook = new AddBook(app.Services.GetRequiredService<IBookRepository>());

addBook.Execute("Test Book", "Test Author", 2022);

var getBooks = app.Services.GetRequiredService<GetBooks>();

foreach (var book in getBooks.Execute())
{
    Console.WriteLine(book.Title);
}