using System;
using System.Collections.Generic;
using System.Linq;

public class Solution_120812
{
    public int solution(int[] array)
    {
        List<int> list = Enumerable.Distinct(array).ToList<int>();
        List<int> count_list = new List<int>();

        foreach (int x in list)
        {
            int count = 1;
            for (int y = 0; y < array.Length; y++)
            {
                if (x.Equals(array[y])) { count++; }
            }
            count_list.Add(count);
        }
        int maxValue = count_list.Max();
        int max_index = count_list.IndexOf(maxValue); //최빈값이 있는 인덱스

        if ((count_list.IndexOf(maxValue, max_index + 1) == -1)) { return maxValue; } //최빈값으로 기록된 값이 하나 뿐일때

        return -1;
    }
    public static void Main()
    {
        Solution_120812 instance = new Solution_120812();
        int[] sibal = { 1, 2, 3, 3, 3, 4 };
        int result = instance.solution(sibal);
        Console.WriteLine(result);
    }
}