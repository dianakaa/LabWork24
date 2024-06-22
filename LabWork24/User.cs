using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork24
{
    internal class User
    {
        private static string login = "Diana";
        private static string password = "abc123";

        private static bool IsCorrectUserData(string inputLogin, string inputPassword, string confirmPassword)
        {
            bool isLoginCorrect = !string.IsNullOrEmpty(inputLogin);
            bool isPasswordCorrect = !string.IsNullOrEmpty(inputPassword);
            bool isConfirmCorrect = inputPassword == confirmPassword;

            return isLoginCorrect && isPasswordCorrect && isConfirmCorrect;
        }
    }
}
