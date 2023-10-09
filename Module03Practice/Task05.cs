using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module03Practice
{
    internal class Task05
    {
        static void Main()
        {
            int[,] array = new int[5, 5];
            Random random = new Random();

            // Заполняем массив случайными числами от -100 до 100
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = random.Next(-100, 101);
                }
            }

            // Находим минимальный и максимальный элементы
            int min = array[0, 0];
            int max = array[0, 0];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
            }

            // Находим сумму элементов между минимальным и максимальным элементами
            int sum = 0;
            bool isBetween = false;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (array[i, j] == min)
                    {
                        isBetween = !isBetween;
                    }
                    else if (array[i, j] == max)
                    {
                        isBetween = !isBetween;
                    }
                    else if (isBetween)
                    {
                        sum += array[i, j];
                    }
                }
            }

            Console.WriteLine("Двумерный массив:");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Сумма элементов между минимальным ({min}) и максимальным ({max}) элементами: {sum}");
        }
    }
}
