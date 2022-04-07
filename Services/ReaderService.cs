using LibraryApp.Data;
using LibraryApp.Entities;
using System.Collections.Generic;


namespace LibraryApp.Services
{
    class ReaderService : IReaderService
    {
        private readonly IUnitOfWork _unitOfWork = new UnitOfWork();
        private readonly IRepository _repository;



        public ReaderService()
        {
            _repository = _unitOfWork.Repository;
        }

        public IEnumerable<Reader> GetReaders()
        {
            //deserialization
            return _repository.GetReaders();
        }


        public void AddReader(Reader reader)
        {
            _repository.AddReader(reader);
            _unitOfWork.ReadersSaveChanges();
         
        }

        public void RemoveReader(int readerId)
        {
            _repository.RemoveReader(readerId);
            _unitOfWork.ReadersSaveChanges();
        }


        public void UpdateReader(Reader reader, int readerId)
        {
            _repository.UpdateReader(reader, readerId);
            _unitOfWork.ReadersSaveChanges();
        }

        public int GetMaxId()
        {
            return _repository.GetMaxIdReader();
        }
    }
}
