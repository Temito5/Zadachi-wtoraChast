using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            for (int i = floors; i >= 1; i--)
            {
                for (int j = 0; j < rooms; j++)
                {
                    if (i == floors)
                    {
                        Console.WriteLine($"L{i}{j}  ");
                    }
                    else
                     if (i % 2 != 0)
                    {
                        Console.WriteLine($"A{i}{j}  ");
                    }
                    else
                     if (i % 2 == 0)
                    {
                        Console.WriteLine($"O{i}{j}  ");
                    }
                }
            }
        }
    }
}
