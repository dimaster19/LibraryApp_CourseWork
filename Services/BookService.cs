using LibraryApp.Data;
using LibraryApp.Entities;
using System.Collections.Generic;
namespace LibraryApp.Services
{
    class BookService : IBookService
    {

        private readonly IUnitOfWork _unitOfWork = new UnitOfWork();
        private readonly IRepository _repository;



        public BookService()
        {
            _repository = _unitOfWork.Repository;
        }

        public IEnumerable<Book> GetBooks()
        {
            
            return _repository.GetBooks();
        }


        public void AddBook(Book book)
        {
            _repository.AddBook (book);
            _unitOfWork.BooksSaveChanges();

        }

        public void RemoveBook(int bookId)
        {
            _repository.RemoveBook(bookId);
            _unitOfWork.BooksSaveChanges();
        }


        public void UpdateBook(Book book, int bookId)
        {
            _repository.UpdateBook(book, bookId);
            _unitOfWork.BooksSaveChanges();
        }

        public int GetMaxId()
        {
            return _repository.GetMaxIdBook();
        }

    }
}
