using LibraryApp.Entities;
using System.Collections.Generic;

namespace LibraryApp.Data
{
    interface IRepository
    {
        void AddReader(Reader _reader);
        void AddWorker(Worker _worker);
        void AddBook(Book _book);
        IEnumerable<Reader> GetReaders();
        IEnumerable<Worker> GetWorkers();
        IEnumerable<Book> GetBooks();
        IEnumerable<Reader> GetListReaders();
        IEnumerable<Worker> GetListWorkers();
        IEnumerable<Book> GetListBooks();
        void RemoveReader (int readerId);
        void RemoveWorker (int workerId);
        void RemoveBook(int bookId);
        void UpdateReader(Reader _reader, int readerId);
        void UpdateWorker(Worker _worker, int workerId);
        void UpdateBook(Book _book, int bookId);
        int GetMaxIdReader();
        int GetMaxIdWorker();
        int GetMaxIdBook();

    }
}