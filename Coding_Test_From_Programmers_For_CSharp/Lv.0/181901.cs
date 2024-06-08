using System;
using System.Collections.Generic;


//Lv.0 : 배열 만들기 1
public class Solution_181901
{
    public int[] solution(int n, int k)
    {
        List<int> list = new List<int>();

        for (int x = 1; x <= n; x++)
        {
            if (x % k == 0)
            {
                list.Add(x);
            }

        }
        int[] answer = list.ToArray();
        return answer;
    }
}