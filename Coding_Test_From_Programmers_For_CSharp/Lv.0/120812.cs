using System;
using System.Collections.Generic;
using System.Linq;

//Lv.0 : 최빈값 구하기

public class Solution_120812
{
    public int solution(int[] array)
    {
        List<int> distinct_List = Enumerable.Distinct(array).ToList<int>();
        List<int> count_list = new List<int>();
        int count = 0;

        foreach (int x in distinct_List)
        {
            for (int y = 0; y < array.Length; y++)
            {
                if (x.Equals(array[y])) { count++; }
            }
            count_list.Add(count);
            count = 0;
        }

        int maxValue = count_list.Max(); //최빈값의 최고 빈도 수. 중복일 수도 있음.
        int max_index = count_list.IndexOf(maxValue); //빈도 리스트 중에 최빈값의 인덱스. 중복일 수도 있음.

        if ((count_list.LastIndexOf(maxValue) != max_index)) //만약 빈도 리스트가 중복된 값이 있을 경우.
        {
            return -1;
        }
        int result = distinct_List[max_index];

        return result;

    }
}