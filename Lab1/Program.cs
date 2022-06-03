using System;
using System.Linq;

namespace Lab1
{
    internal class Program
    {
        private static int[] ArrayInitialize(int length)
        {
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Введите значение {i} элемента массива: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            return array;
        }
        private static void ArrayPrint(int[] array)
        {
            foreach(int item in array)
            {
                Console.Write(item+" ");
            }
        }
        static void Main(string[] args)
        {
            //размерность массивов
            int array_len = 0;
            //ввод длины первого массива
            Console.Write("Введите колличество элементов в первом массиве: ");
            array_len = Convert.ToInt32(Console.ReadLine());
            //объявление и инициализация массива 
            int[] array1 = ArrayInitialize(array_len);
            //ввод длины второго массива
            Console.Write("Введите колличество элементов во втором массиве: ");
            array_len = Convert.ToInt32(Console.ReadLine());
            //объявление и инициализация массива 
            int[] array2 = ArrayInitialize(array_len);
            //использовние функции UNION для объединения двух массивов
            var rez = array1.Union(array2).ToArray();
            //вывод результата
            Console.Write($"\nРезультат объединения множеств: ");
            ArrayPrint(rez);

            Console.ReadLine();
        }
    }
}
