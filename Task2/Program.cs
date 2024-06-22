namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Diana", "abc123");

            Console.Write("Введите логин: ");
            string login = Console.ReadLine();

            Console.Write("Введите пароль: ");
            string password = Console.ReadLine();

            Console.WriteLine("Подтвердите пароль: ");
            string confirm = Console.ReadLine();

            if (user1.IsCorrectUserData(login, password, confirm))
            {
                Console.WriteLine("Регистрация прошла успешно.");
            }
            else
            {
                Console.WriteLine("Не удалось зарегистрироваться.");
            }
        }
    }
}
