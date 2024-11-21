using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ssprokofeva_lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // задание 1. Вывести на экран массив из 20 случайных чисел. Ввести два числа из этого массива, которые нужно поменять местами. Вывести на экран получившийся массив.
            Console.WriteLine("задание 1.");
            Random random = new Random();
            int[] arr = new int[20];
            for (int i = 0; i < 20; i++)
            {
                arr[i] = random.Next(1, 101); // Числа от 1 до 100
            }

            Console.WriteLine("Исходный массив: " + string.Join(", ", arr));

            Console.Write("Введите индекс первого элемента: ");
            int index1 = int.Parse(Console.ReadLine());

            Console.Write("Введите индекс второго элемента: ");
            int index2 = int.Parse(Console.ReadLine());

            (arr[index1], arr[index2]) = (arr[index2], arr[index1]); // Одновременное присваивание

            Console.WriteLine("Массив после обмена: " + string.Join(", ", arr));
            // задание 2. Написать метод, где в качества аргумента будет передан массив (ключевое слово params). Вывести сумму элементов массива(вернуть). Вывести(ref) произведение
            //массива.Вывести(out) среднее арифметическое в массиве.
            if (arr.Length == 0)
            {
                Console.WriteLine("Пустой массив, невозможно выполнить вычисленияэ");
                product = 0;
                average = 0;
                return 0;
            }
            int sum = 0;
            product = 1;
            foreach (int num in arr)
            {
                sum += num;
            }
            average = (double)sum / arr.Length;
            Console.WriteLine($"сумма элементов массива: {sum}");
            Console.WriteLine($"произведение: {product}");
            Console.WriteLine($"среднее арифмитическое:{average");
                return sum;

        }
    }
}
