using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j = 2;
            int sum = 2;
            while (j < 4000000)
            {
                int temp = i;
                i = j;
                j = temp + j;
                if (j % 2 == 0)
                    sum += j;
            }
            Console.WriteLine("Sum is " + sum);
        }
    }
}
