using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Class10
    {
        static void Main(string[] args)
        {
            int n, r, sum = 0, x;
            Console.WriteLine("Enter your number");
            n = Convert.ToInt32(Console.ReadLine());
            x = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;

            }
            if (x == sum)
            {
                Console.WriteLine("Armstrong Number");
            }
            else
            {
                Console.WriteLine("Not Armstrong Number");
            }
        }
    }
}
