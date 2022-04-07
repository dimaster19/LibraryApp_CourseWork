using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Data
{
    class UnitOfWork : IUnitOfWork
    {

        public IRepository Repository { get; } = new Repository();
        public void ReadersSaveChanges()
        {
            var readers = Repository.GetListReaders();

            var json = JsonConvert.SerializeObject(readers, Formatting.Indented,
                            new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });

            using (var f = File.CreateText("readersData.json"))
            {
                f.Write(json);
            }
        }


        public void WorkersSaveChanges()
        {
            var workers = Repository.GetListWorkers();

            var json = JsonConvert.SerializeObject(workers, Formatting.Indented,
                            new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });

            using (var f = File.CreateText("workersData.json"))
            {
                f.Write(json);
            }
        }


        public void BooksSaveChanges()
        {
            var books = Repository.GetListBooks();

            var json = JsonConvert.SerializeObject(books, Formatting.Indented,
                            new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });

            using (var f = File.CreateText("booksData.json"))
            {
                f.Write(json);
            }
        }

    }
}
