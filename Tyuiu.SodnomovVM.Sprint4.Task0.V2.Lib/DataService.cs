using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SodnomovVM.Sprint4.Task0.V2.Lib
{
    public class DataService : ISprint4Task0V2
    {
        public int GetSumOddArrEl(int[] array)
        {
            int i = 0;
            int sum = 0;
            while(i<=array.Length - 1)
            {
                if (array[i]%2==1)
                {
                    sum += array[i];
                }
                i++;
            }
            return sum;
        }
    }
}
