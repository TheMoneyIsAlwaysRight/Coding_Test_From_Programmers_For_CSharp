using System;
using System.Collections.Generic;
using System.IO;

/*
 * Lv. 0 : 카운트 다운 
 */
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
}

