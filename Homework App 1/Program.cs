using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_App_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArr = new int[20, 40];

            Random ran = new Random();

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                    myArr[i, j] = ran.Next(1, 15);
                    Console.Write("{0}\t", myArr[i, j]);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
