using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module03Practice
{
    internal class Task04
    {
        static void Main()
        {
            Console.WriteLine("Введите предложение:");
            string input = Console.ReadLine();

            // Разбиваем строку на слова
            string[] words = input.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            // Выводим количество слов
            Console.WriteLine($"Количество слов в предложении: {words.Length}");
        }
    }
}
