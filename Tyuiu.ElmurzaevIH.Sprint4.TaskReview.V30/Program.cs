using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ElmurzaevIH.Sprint4.TaskReview.V30.Lib;

namespace Tyuiu.ElmurzaevIH.Sprint4.TaskReview.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Ельмурзаев И.Х. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: SprintReview                                                      *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Ельмурзаев Ислам Хаважевич | ИИПб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"684259137159648\". Преобразуйте ее  *");
            Console.WriteLine("* в матрицу 5 на 3 и подсчитайте произведение четных чисел в матриц       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int rows = 5;
            int cols = 3;

            int[,] mtrx = new int[rows, cols];
            string str = "684259137159648";

            int index = 0;

            Console.WriteLine("\nМассив");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(rows, cols, str);
            Console.WriteLine("Произведение четных чисел в матрице = " + res);
            Console.ReadKey();
        }
    }
}
