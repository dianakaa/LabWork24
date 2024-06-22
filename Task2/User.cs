using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class User
    {
        private string _login;
        private string _password;
        public User(string login, string password)
        {
            _login = login;
            _password = password;
        }
        public bool IsCorrectUserData(string login, string password, string confirm)
        {
            bool isLoginCorrect = !string.IsNullOrEmpty(login);
            bool isPasswordCorrect = !string.IsNullOrEmpty(password);
            bool isConfirmCorrect = password == confirm;

            return isLoginCorrect && isPasswordCorrect && isConfirmCorrect;
        }
    }
}
