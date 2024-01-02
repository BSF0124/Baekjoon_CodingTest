using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split();
            int find_num = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i=0; i<n; i++)
            {
                if(int.Parse(s[i]) == find_num)
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}