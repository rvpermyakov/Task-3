using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucntion
{
    class Program
    {
        static private double F(double x)
        {
            if (x < 0)
            {
                return -x;
            }
            else if (x < 1)
            {
                return x;
            }
            else if (x < 2)
            {
                return 1;
            }
            else
            {
                return 5 - 2 * x;
            }

        }

        static int Main()
        {
            {
                double x;
                x = double.Parse(Console.ReadLine());
                Console.Write(F(x));
                return 0;
            }

        }
    }
}
