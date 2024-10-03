using System.Globalization;

namespace RemainderOfDivision
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                string InputA, InputB;
                int a, b, quotient, remainder;

                Console.WriteLine("Введите числитель:");
                InputA = Console.ReadLine();

                try
                {
                    a = int.Parse(InputA);
                }
                catch (Exception)
                {
                    Console.WriteLine($"Некорректный ввод: {InputA}. Перевведите");
                    continue;
                } 

                Console.WriteLine("Введите знаменатель:");
                InputB = Console.ReadLine();
                try
                {
                    b = int.Parse(InputB);
                }
                catch (Exception)
                {
                    Console.WriteLine($"Некорректный ввод: {InputB}. Перевведите");
                    continue;
                }

                if (b == 0)
                {
                    Console.WriteLine("Некорректный ввод. Знаменатель не может быть равен 0");
                    continue;
                }

                quotient = a / b;
                remainder = a % b;
                Console.WriteLine($"Результат деления: {quotient}, Остаток от деления: {remainder}");
                Console.WriteLine("---------------------------------------------------------------");
            }
        }
    }
}
