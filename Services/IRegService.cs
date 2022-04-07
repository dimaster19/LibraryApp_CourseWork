namespace LibraryApp.Services
{
    interface IRegService
    {
        string Check(string login, string password1, string password2);
    }
}