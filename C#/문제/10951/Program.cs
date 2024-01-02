using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string input = Console.ReadLine();
                if(input == null) break;
                string[] s = input.Split();
                int a = int.Parse(s[0]);
                int b = int.Parse(s[1]);
                Console.WriteLine(a+b);
            }
        }
    }
}