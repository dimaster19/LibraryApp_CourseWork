namespace LibraryApp.Entities
{
    class Worker : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ExpYears { get; set; }
        public string Address { get; set; }

    }
}
