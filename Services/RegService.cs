using Newtonsoft.Json;
using LibraryApp.Data;
using LibraryApp.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp.Services
{
    class RegService : IRegService
    {
        public Account Account { get; set; }
        public IAuthService auth { get; } = new AuthService();
        public string Check(string login, string password1, string password2)
        {
            if (password1.Length >= 8)
            {
                bool en = true;
                bool number = false;
                for (int i = 0; i < password1.Length; i++)
                {
                    if (password1[i] >= 'А' & password1[i] <= 'Я') en = false;
                    if (password1[i] >= '0' & password1[i] <= '9') number = true;
                }
                if (!en)
                    return "Доступна только английская раскладка";
                else if (!number)
                    return "Добавьте хотя бы одну цифру";
                if (en && number)
                {
                    var randomizer = new Random();
                    if (password1 == password2)
                    {
                        Account = new Account
                        {
                            Id = randomizer.Next(),
                            Login = login,
                            Password = password1,
                            Roles = "User"
                        };
                        auth.GetAccounts();
                        auth.AddAccount(Account);
                        return "Пользователь успешно зарегистрирован";
                    }
                    else
                    {
                        return "Пароли не совпадают";
                    }
                }
                else return null;
            }
            else return "Пароль слишком короткий, минимум 8 символов";
        }
        
    }
}
