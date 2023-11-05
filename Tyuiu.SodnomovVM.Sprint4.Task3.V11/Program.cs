using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
   using Tyuiu.SodnomovVM.Sprint4.Task3.V11.Lib;


namespace Tyuiu.SodnomovVM.Sprint4.Task3.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Содномов В.М. | СмартБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Содномов Валерий Михайлович | СмартБ-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая суммирует значения двух    *");
            Console.WriteLine("* одинаковых массивов по длинне.                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Посчитать количество нечетных чисел в массиве{{8, 6, 9, 4, 5},{9, 4, 8, 5, 6},{9, 7, 9, 8, 4,},{4, 6, 5, 7, 8,},{6, 6, 7, 6, 4,}");


            int[,] massive = new int[5, 5] { { 8, 6, 9, 4, 5 }, { 9, 4, 8, 5, 6 }, { 9, 7, 9, 8, 4, }, { 4, 6, 5, 7, 8, }, { 6, 6, 7, 6, 4 } };

           
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество четных элементов массива равно:");
            Console.WriteLine(ds.Calculate(massive));
            Console.ReadKey();
        }
    }
}
