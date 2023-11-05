using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SodnomovVM.Sprint4.Task3.V11.Lib
{
    public class DataService : ISprint4Task3V11
    {
        public int Calculate(int[,] array)
        {
            int count = 0;
            for (int  i = 0; i <= 4; i++)
            {
                for (int j = 0; j<=4; j++)
                {
                    if (array[i,j] % 2 == 1)
                    {
                        count += 1;
                    }
                }
            }
            return count;
                
        }
    }
}
