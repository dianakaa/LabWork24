namespace Task3
{
    internal class Program
    {
        private int GetDaysCount(int month, int year)
        {
            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (month < 1 || month > 12)
            {
                throw new ArgumentException("Такого месяца нет.");
            }
            int days = daysInMonth[month - 1];

            if (month == 2 && (year % 400 == 0 || (year % 100 != 0 && year % 4 == 0)))
            {
                days++;
            }

            return days;
        }
        static void Main(string[] args)
        {

        }
    }
}
