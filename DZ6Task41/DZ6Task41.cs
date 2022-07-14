// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

namespace DZ
{
    class Task41
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Введите любое количество целых чисел (через запятую и без пробелов)");
            string? numbers = Console.ReadLine();
            string[] str = numbers.Split(',');
            int count = 0;

            Console.WriteLine("--------------------------------");

            for (int i = 0; i < str.Length; i++)
            {
                int num = Convert.ToInt32(str[i].ToString());

                if (num > 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество введённых Вами чисел больше ноля: {count}");
        }
    }
}
