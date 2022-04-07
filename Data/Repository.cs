using Newtonsoft.Json;
using LibraryApp.Entities;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace LibraryApp.Data
{
    class Repository : IRepository
    {

        private List<Reader> _readers = new List<Reader>();
        private List<Worker> _workers = new List<Worker>();
        private List<Book> _books = new List<Book>();

        public IEnumerable<Reader> GetListReaders()
        {
            return _readers.ToArray();
        }
        public IEnumerable<Worker> GetListWorkers()
        {
            return _workers.ToArray();
        }
        public IEnumerable<Book> GetListBooks()
        {
            return _books.ToArray();
        }

        public IEnumerable<Reader> GetReaders()
        {

            if (!File.Exists("readersData.json"))
            {
                return null;
            }

            using (var f = File.OpenText("readersData.json"))
            {
                var json = f.ReadToEnd();
                _readers = JsonConvert.DeserializeObject<Reader[]>(json,
                    new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects }).ToList();
                return JsonConvert.DeserializeObject<Reader[]>(json,
                            new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
            }

        }
        public IEnumerable<Worker> GetWorkers()
        {
            if (!File.Exists("workersData.json"))
            {
                return null;
            }

            using (var f = File.OpenText("workersData.json"))
            {
                var json = f.ReadToEnd();
                _workers = JsonConvert.DeserializeObject<Worker[]>(json,
                    new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects }).ToList();
                return JsonConvert.DeserializeObject<Worker[]>(json,
                            new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
            }
        }

        public IEnumerable<Book> GetBooks()
        {
            if (!File.Exists("booksData.json"))
            {
                return null;
            }

            using (var f = File.OpenText("booksData.json"))
            {
                var json = f.ReadToEnd();
                _books = JsonConvert.DeserializeObject<Book[]>(json,
                    new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects }).ToList();
                return JsonConvert.DeserializeObject<Book[]>(json,
                            new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
            }
        }

        public void AddReader(Reader reader)
        {
            _readers.Add(reader);
        }

        public void AddWorker(Worker worker)
        {
            _workers.Add(worker);

        }

        public void AddBook(Book book)
        {
            _books.Add(book);

        }
        public void RemoveReader(int id)
        {

            var reader = _readers.FirstOrDefault(r => r.Id == id);

            if (reader != null)
            {
                _readers.Remove(reader);
            }
        }
        public void RemoveWorker(int id)
        {
            var worker = _workers.FirstOrDefault(w => w.Id == id);

            if (worker != null)
            {
                _workers.Remove(worker);
            }
        }

        public void RemoveBook(int id)
        {
            var book = _books.FirstOrDefault(b => b.Id == id);

            if (book != null)
            {
                _books.Remove(book);
            }
        }


        public void UpdateReader (Reader reader, int readerId)
        {
            _readers[_readers.IndexOf(_readers.FirstOrDefault(r => r.Id == readerId))] = reader;


        }

        public void UpdateWorker(Worker worker, int workerId)
        {

            _workers[_workers.IndexOf(_workers.FirstOrDefault(w => w.Id == workerId))] = worker;
        }


        public void UpdateBook(Book book, int bookId)
        {

            _books[_books.IndexOf(_books.FirstOrDefault(b => b.Id == bookId))] = book;
        }

        public int GetMaxIdReader()
        {
            int temp = GetReaders().Max(reader => reader.Id); ;
            return temp;
        }


        public int GetMaxIdWorker()
        {
            int temp = GetWorkers().Max(worker => worker.Id); ;
            return temp;
        }

        public int GetMaxIdBook()
        {
            int temp = GetBooks().Max(book => book.Id); ;
            return temp;
        }
    }


}
