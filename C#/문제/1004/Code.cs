using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int casenum = int.Parse(Console.ReadLine());
            while (casenum > 0)
            {
                int[,] fiboarray = new int[41, 2];
                fiboarray[0,0] = 1;
                fiboarray[1,1] = 1;
                int test = int.Parse(Console.ReadLine());
                for(int i = 2; i <= test; i++)
                {
                    fiboarray[i,0] = fiboarray[i-1, 0] + fiboarray[i-2, 0];
                    fiboarray[i,1] = fiboarray[i-1, 1] + fiboarray[i-2, 1];
                }
                Console.WriteLine("{0} {1}", fiboarray[test,0], fiboarray[test, 1]);
                casenum--;
            }
        }
    }
}