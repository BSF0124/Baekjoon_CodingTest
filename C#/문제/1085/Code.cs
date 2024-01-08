string[] str = Console.ReadLine().Split();

int x = int.Parse(str[0]);
int y = int.Parse(str[1]);
int w = int.Parse(str[2]);
int h = int.Parse(str[3]);

List<int> distance = new List<int>();

distance.Add(x);
distance.Add(y);
distance.Add(w-x);
distance.Add(h-y);
distance.Sort();

Console.WriteLine(distance[0]);