int n = int.Parse(Console.ReadLine());

int i = 1;
int num = 1;
int sum = 0;

while(true)
{
    sum += num;

    if(n <= sum)
    {
        Console.WriteLine(i);
        break;
    }
    
    else
    {
        num = i*6;
        i++;
    }
}