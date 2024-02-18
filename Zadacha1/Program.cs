using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <=23; i++)
            {
                for (int m = 0; m <=59; m++)
                {
                    Console.WriteLine($"{i}:{m}");
                }
            }
        }
    }
}
