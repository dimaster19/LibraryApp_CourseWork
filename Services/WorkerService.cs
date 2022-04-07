using LibraryApp.Data;
using LibraryApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Services
{
    class WorkerService : IWorkerService
    {
        private readonly IUnitOfWork _unitOfWork = new UnitOfWork();
        private readonly IRepository _repository;



        public WorkerService()
        {
            _repository = _unitOfWork.Repository;
        }

        public IEnumerable<Worker> GetWorkers()
        {
            //deserialization
            return _repository.GetWorkers();
        }


        public void AddWorker(Worker worker)
        {
            _repository.AddWorker(worker);
            _unitOfWork.WorkersSaveChanges();

        }

        public void RemoveWorker(int workerId)
        {
            _repository.RemoveWorker(workerId);
            _unitOfWork.WorkersSaveChanges();
        }

        public void UpdateWorker(Worker worker, int workerId)
        {
            _repository.UpdateWorker(worker, workerId);
            _unitOfWork.WorkersSaveChanges();
        }

        public int GetMaxId()
        {
            return _repository.GetMaxIdWorker();
        }
    }
}
