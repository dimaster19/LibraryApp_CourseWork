using LibraryApp.Entities;
using System.Collections.Generic;

namespace LibraryApp.Services
{
    interface IAuthService
    {
        void AddAccount(Account account);
        bool Authorize(string login, string password);
        IEnumerable<Account> GetAccounts();
        IEnumerable<Account> GetListAccounts();
    }
}