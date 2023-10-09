using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module03Practice
{
    internal class Task03
    {
        static void Main()
        {
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            // Удаляем пробелы и приводим строку к нижнему регистру
            string cleanedInput = input.Replace(" ", "").ToLower();

            bool isPalindrome = true;

            for (int i = 0; i < cleanedInput.Length / 2; i++)
            {
                if (cleanedInput[i] != cleanedInput[cleanedInput.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine("Эта строка является палиндромом.");
            }
            else
            {
                Console.WriteLine("Эта строка не является палиндромом.");
            }
        }
    }
}
