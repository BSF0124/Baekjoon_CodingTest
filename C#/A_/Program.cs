using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] s = Console.ReadLine().Split();

            double w = int.Parse(s[0]);
            double h = int.Parse(s[1]);
            double area = ((w * h) / 2.0);

            Console.WriteLine("{0:N1}", area);
        }
    }
}