using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SodnomovVM.Sprint4.Task1.V19.Lib
{
    public class DataService : ISprint4Task1V19
    {
        public int Calculate(int[] array)
        {
            int i = 0;
            int sum = 0;
            while (i <= array.Length - 1)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }
                i++;
            }
            return sum;
        }
    }
}
