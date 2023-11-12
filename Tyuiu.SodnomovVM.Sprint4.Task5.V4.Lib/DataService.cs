﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SodnomovVM.Sprint4.Task5.V4.Lib
{
    public class DataService : ISprint4Task5V4
    {
        public int Calculate(int[,] matrix)
        {
            int count = 0;
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= 4; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        count += 1;
                    }
                }
            }
            return count;
        }
    }
}
