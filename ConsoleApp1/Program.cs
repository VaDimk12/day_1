using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int prev = 0;
            int yet = 1;
            int n = 40;
            for(int i = 2; i < n; i++)
            {
                int next = prev + yet;
                Console.WriteLine(next);

                prev = yet;
                yet = next;
            }

            Console.ReadLine();
        }
    }
}
