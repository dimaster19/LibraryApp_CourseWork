namespace LibraryApp.Entities
{
    class Reader : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public string Book { get; set; }
    }
}
