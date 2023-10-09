using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module03Practice
{
    internal class Task01
    {
        static void Main()
        {
            // Создаем одномерный и двумерный массивы
            double[] A = new double[5];
            double[,] B = new double[3, 4];

            // Заполняем одномерный массив с клавиатуры
            Console.WriteLine("Введите 5 чисел для массива A:");
            for (int i = 0; i < 5; i++)
            {
                A[i] = double.Parse(Console.ReadLine());
            }

            // Заполняем двумерный массив случайными числами
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = random.NextDouble();
                }
            }

            // Выводим массив A
            Console.WriteLine("Массив A:");
            foreach (double num in A)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            // Выводим массив B в виде матрицы
            Console.WriteLine("Массив B:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(B[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Находим общий максимальный и минимальный элементы
            double maxA = A[0];
            double minA = A[0];
            double maxB = B[0, 0];
            double minB = B[0, 0];
            double sum = 0;
            double product = 1;
            double evenSum = 0;

            foreach (double num in A)
            {
                if (num > maxA) maxA = num;
                if (num < minA) minA = num;
                sum += num;
                product *= num;
                if (num % 2 == 0) evenSum += num;
            }

            foreach (double num in B)
            {
                if (num > maxB) maxB = num;
                if (num < minB) minB = num;
                sum += num;
                product *= num;
            }

            Console.WriteLine($"Максимальный элемент: {Math.Max(maxA, maxB)}");
            Console.WriteLine($"Минимальный элемент: {Math.Min(minA, minB)}");
            Console.WriteLine($"Сумма всех элементов: {sum}");
            Console.WriteLine($"Произведение всех элементов: {product}");
            Console.WriteLine($"Сумма четных элементов массива A: {evenSum}");

            double oddColumnsSum = 0;
            for (int j = 0; j < 4; j++)
            {
                if (j % 2 != 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        oddColumnsSum += B[i, j];
                    }
                }
            }
            Console.WriteLine($"Сумма нечетных столбцов массива B: {oddColumnsSum}");
        }
    }
}
