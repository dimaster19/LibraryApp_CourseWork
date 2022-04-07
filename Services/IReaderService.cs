using LibraryApp.Entities;
using System.Collections.Generic;

namespace LibraryApp.Services
{
    interface IReaderService
    {
        void AddReader(Reader reader);
        IEnumerable<Reader> GetReaders();
        void RemoveReader(int readerId);
        void UpdateReader(Reader reader, int readerId);
        int GetMaxId();
        
    }
}