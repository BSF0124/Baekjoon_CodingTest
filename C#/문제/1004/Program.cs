using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine()); // 테스트 케이스 t
            for(int i=0; i<t; i++)
            {
                int count = 0; // 행성 진입/이탈 횟수

                // 좌표 입력
                string[] s1 = Console.ReadLine().Split();

                int start_x = int.Parse(s1[0]); // 시작점 x
                int start_y = int.Parse(s1[1]); // 시작점 y

                int arrival_x = int.Parse(s1[2]); // 도착점 x
                int arrival_y = int.Parse(s1[3]); // 도착점 y

                // 행성 개수 n
                int n = int.Parse(Console.ReadLine());

                int[,] planet = new int[n,3];
                for(int j=0; j<n; j++)
                {
                    string[] s2 = Console.ReadLine().Split();
                    planet[j,0] = int.Parse(s2[0]);
                    planet[j,1] = int.Parse(s2[1]);
                    planet[j,2] = int.Parse(s2[2]);
                }

                for(int k=0; k<n; k++)
                {
                    // 행성의 중점과 출발점/도착점 사이의 거리
                    double start_distance = Math.Sqrt(Math.Pow((double)(start_x - planet[k,0]),2) + Math.Pow((double)(start_y - planet[k,1]),2));
                    double arrival_distance = Math.Sqrt(Math.Pow((double)(arrival_x - planet[k,0]),2) + Math.Pow((double)(arrival_y - planet[k,1]),2));

                    if(start_distance <= planet[k,2] && arrival_distance <= planet[k,2])
                        continue;
                    else if(start_distance < planet[k,2])
                        count++;
                    else if(arrival_distance < planet[k,2])
                        count++;
                    else
                        continue;
                }
                Console.WriteLine(count);
            }
        }
    }
}