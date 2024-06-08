using System;
using System.Collections.Generic;
using System.IO;
public class Solution_181899
{
    public int[] solution(int start, int end_num)
    {
        List<int> list = new List<int>();
        while (start >= end_num)
        {
            list.Add(start--);
        }
        int[] answer = list.ToArray();
        return answer;
    }


    public static void Main()
    {
        Solution_181899 instance = new Solution_181899();

        int start = 10;

        int end_num = 3;

        int[] result = instance.solution(start, end_num);

        foreach(int x in result)
        {
            Console.Write($"{x}");
        }
    }
}

