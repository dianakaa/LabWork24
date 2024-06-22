namespace LabWork24
{
    class Program
    {
        private static string _login = "Diana";
        private static string _password = "abc123";

        private static bool IsCorrectUserData(string login, string password, string confirm)
        {
            bool isLoginCorrect = !string.IsNullOrEmpty(login);
            bool isPasswordCorrect = !string.IsNullOrEmpty(password);
            bool isConfirmCorrect = password == confirm;

            return isLoginCorrect && isPasswordCorrect && isConfirmCorrect;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите логин: ");
            string inputLogin = Console.ReadLine();

            Console.WriteLine("Введите пароль: ");
            string inputPassword = Console.ReadLine();

            Console.WriteLine("Подтвердите пароль: ");
            string confirmPassword = Console.ReadLine();

            if (IsCorrectUserData(inputLogin, inputPassword, confirmPassword))
            {
                _login = inputLogin;
                _password = inputPassword;
                Console.WriteLine("Регистрация прошла успешно.");
            }
            else
            {
                Console.WriteLine("Не удалось зарегистрироваться.");
            }
        }
    }
}
