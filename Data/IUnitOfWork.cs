namespace LibraryApp.Data
{
    interface IUnitOfWork
    {
        IRepository Repository { get; }

        void WorkersSaveChanges();
        void ReadersSaveChanges();

        void BooksSaveChanges();
    }
}