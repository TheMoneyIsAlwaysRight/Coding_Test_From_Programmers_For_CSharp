using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


//Lv.0 : 문자열의 앞의 n글자
public class Solution_181907
{
    public string solution(string my_string, int n)
    {
        string answer = "";

        List<char> list = my_string.ToCharArray().ToList<char>();

        for (int x = 0; x < my_string.Length; x++)
        {
            if (x < n)
            {
                answer += list[0];
                list.RemoveAt(0);
            }
        }
        return answer;
    }
}