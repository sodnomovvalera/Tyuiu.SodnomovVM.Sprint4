using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SodnomovVM.Sprint4.Task1.V19.Lib;

namespace Tyuiu.SodnomovVM.Sprint4.Task1.V19
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
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Содномов Валерий Михайлович | СмартБ-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая суммирует значения двух    *");
            Console.WriteLine("* одинаковых массивов по длинне.                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите 12 чисел в массив, и мы найдем сумму четных чисел массива");
            int[] massive = new int[12];

            for (int i = 0; i <= 11 ; i++)
            {
                massive[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(massive));
            Console.ReadKey();

        }
    }
}
