using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SodnomovVM.Sprint4.Task4.V8.Lib
{
    public class DataService : ISprint4Task4V8
    {
        public int[,] Calculate(int[,] matrix)
        {
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= 4; j++)
                {
                    if (matrix[i, j] % 2 == 1)
                    {
                        matrix[i, j] = 1;
                    }
                }
            }
            return matrix;
        }
    }
}
