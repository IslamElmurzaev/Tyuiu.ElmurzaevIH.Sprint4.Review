using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ElmurzaevIH.Sprint4.TaskReview.V30.Lib
{
    public class DataService : ISprint4Task7V30
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] mtrx = new int[n, m];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }

            int pr = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mtrx[i, j] % 2 == 0)
                    {
                        pr = pr * mtrx[i, j];
                    }
                }
            }
            return pr;
        }
    }
}
