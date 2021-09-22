using System;

namespace LookForIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: \t");
            int ArrNumber = int.Parse(Console.ReadLine());
            int[] array = new int[ArrNumber];

            for (int l = 0; l < ArrNumber; l++)
            {
                Console.Write($"\nВведите число с индексом {l} \t");
                array[l] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.Write("Введите число для определения индекса: \t");
            int value = int.Parse(Console.ReadLine());
            int index = Array.IndexOf(array, value);
            Console.WriteLine("\nИндекс числа в массиве - " + index);
            Console.ReadLine();
        }
    }
}
