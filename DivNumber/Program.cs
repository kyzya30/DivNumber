using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divider_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value:");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine("Result:");
            for (int i = 1; i <= value; i++)
            {
                if (value % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
