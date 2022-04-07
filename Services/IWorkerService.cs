using LibraryApp.Entities;
using System.Collections.Generic;

namespace LibraryApp.Services
{
    interface IWorkerService
    {
        void AddWorker(Worker worker);
        IEnumerable<Worker> GetWorkers();
        void RemoveWorker(int id);
        void UpdateWorker(Worker worker, int workerId);
        int GetMaxId();
    }
}