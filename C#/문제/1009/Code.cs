int t = int.Parse(Console.ReadLine());

for(int i=0; i<t; i++)
{
    string[] str = Console.ReadLine().Split();

    int a = int.Parse(str[0]) % 10;
    int b = int.Parse(str[1]);
    int cpu = 1;

    for(int j=1; j<=b; j++)
    {
        cpu *= a;
        cpu %= 10;
    }
    
    if(cpu == 0) cpu=10;
    
    Console.WriteLine(cpu);
}