using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module03Practice
{
    internal class Task02
    {
        static void Main()
        {
            // Задаем массивы M и N
            int[] M = { 1, 2, 3, 4, 5 };
            int[] N = { 3, 4, 5, 6, 7 };

            // Ищем общие элементы без повторений
            int[] commonElements = M.Intersect(N).Distinct().ToArray();

            // Выводим результат
            Console.WriteLine("Общие элементы без повторений:");
            foreach (int element in commonElements)
            {
                Console.WriteLine(element);
            }
        }
    }
}
