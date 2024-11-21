using System;
 using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
 using System.Linq;

namespace tumakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Упражнение 5.1 Написать метод, возвращающий наибольшее из двух чисел. Входные параметры метода – два целых числа.Протестировать метод.
            Console.WriteLine("упражнение 5.1");
            public static int Max(int a, int b)
        {
            return a > b ? a : b;
        }


        public static void Main(string[] args)
        {
            Console.WriteLine($"Максимум из 5 и 10: {Max(5, 10)}");
            Console.WriteLine($"Максимум из -3 и 0: {Max(-3, 0)}");
            Console.WriteLine($"Максимум из 15 и 15: {Max(15, 15)}");
            Console.WriteLine($"Максимум из -100 и -50: {Max(-100, -50)}");
            Console.WriteLine($"Максимум из int.MaxValue и int.MinValue: {Max(int.MaxValue, int.MinValue)}");
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int num1 = random.Next(int.MinValue, int.MaxValue);
                int num2 = random.Next(int.MinValue, int.MaxValue);
                Console.WriteLine($"Максимум из {num1} и {num2}: {Max(num1, num2)}");

            }
            // Упражнение 5.2 Написать метод, который меняет местами значения двух передаваемых параметров.Параметры передавать по ссылке. Протестировать метод.
            Console.WriteLine("упражнение 5.2");
            public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            Console.WriteLine($"До: x={x}, y={y}");
            Swap(ref x, ref y);
            Console.WriteLine($"После: x={x}, y={y}");
        }
        // Упражнение 5.3 Написать метод вычисления факториала числа, результат вычислений передавать в выходном параметре.Если метод отработал успешно, то вернуть значение true;
        //если в процессе вычисления возникло переполнение, то вернуть значение false. Для отслеживания переполнения значения использовать блок checked.    
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            Console.WriteLine($"До: x={x}, y={y}");
            Swap(ref x, ref y);
            Console.WriteLine($"После: x={x}, y={y}");
        }
        //Упражнение 5.4 Написать рекурсивный метод вычисления факториала числа.
        Console.WriteLine("упражнение 5.4");
public static long FactorialRecursive(int n) => n == 0 ? 1 : n * FactorialRecursive(n - 1);

        public static void Main(string[] args) => Console.WriteLine(FactorialRecursive(5));
    
    }
   

}
