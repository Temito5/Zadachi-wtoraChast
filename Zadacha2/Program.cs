using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=10; i++)
            {
                for (int y = 0; y <=10; y++)
                {
                    int product = i * y;
                    Console.WriteLine($"{i}*{y}={product}");
                }
            }
        }
    }
}
