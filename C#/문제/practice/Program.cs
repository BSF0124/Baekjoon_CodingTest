using System;

class Program
{
    static void Main()
    {
        //리스트 생성 및 초기화
        List<int> list = new List<int>(){10, 20, 30};
        // 리스트에 값 추가
        list.Add(40);
        for(int i = 0; i < list.Count; i++)
        {
            Console.WriteLine($"Element at Index {i} : {list[i]}");
        }

        list.Remove(20);
    }
}