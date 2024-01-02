using System;

namespace test
{
    class Program
    {
        static void Main(string[] args) 
        {
            int times = int.Parse(Console.ReadLine());
            for(int i = 0; i < times; i++)
            {
                string[] s;
                s = Console.ReadLine().Split();

                //첫번째 원
                int x1 = int.Parse(s[0]);
                int y1 = int.Parse(s[1]);
                int r1 = int.Parse(s[2]);

                //두번째 원
                int x2 = int.Parse(s[3]);
                int y2 = int.Parse(s[4]);
                int r2 = int.Parse(s[5]);
                //find_Contact(x1,y1,r1,x2,y2,r2);

                //두 점 사이의 거리
                double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

                //두 원의 반지름의 합
                int r_sum = r1 + r2;

                //두 원의 반지름의 차
                int r_sub = Math.Abs(r1 - r2);

                //접점이 무한대일 경우
                if(x1==x2 && y1==y2 && r1==r2)
                    Console.WriteLine("-1");

                //접점이 1개인 경우
                else if(r_sum == distance || r_sub == distance)
                    Console.WriteLine("1");

                //접하지 않는 경우
                else if(r_sum < distance || r_sub > distance || distance == 0)
                    Console.WriteLine("0");

                //접점이 2개인 경우
                else
                    Console.WriteLine("2");
            }
        }
    }
}