using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int t = 1; t <= T; t++)
            {
                string line = Console.ReadLine();
                string[] space = line.Split(' ');
                if (line.Contains('r'))
                {
                    Console.WriteLine("Not vely easy");
                }
                else
                {
                    Console.WriteLine("Vely easy");
                }
            }
        }
    }
}
