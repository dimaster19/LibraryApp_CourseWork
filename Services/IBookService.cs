using LibraryApp.Entities;
using System.Collections.Generic;

namespace LibraryApp.Services
{
    interface IBookService
    {
        void AddBook(Book book);
        IEnumerable<Book> GetBooks();
        void RemoveBook(int bookId);
        void UpdateBook(Book book, int bookId);
        int GetMaxId();
    }
}