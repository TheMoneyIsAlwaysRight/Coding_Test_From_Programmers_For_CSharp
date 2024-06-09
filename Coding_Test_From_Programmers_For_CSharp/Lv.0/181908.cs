using System;
using System.Linq;
using System.Collections.Generic;


//Lv.0 : 접미사인지 확인하기 ----------> 덜품


public class Solution_181908
{
    public int solution(string my_string, string is_suffix)
    {
        List<string> list = new List<string>();

        for (int x = 0; x < my_string.Length; x++)
        {
            string word = "";
            for (int y = 0; y <= x; y++)
            {
                word += my_string[my_string.Length - (x + 1)];
            }
            if (word != "")
            {
                list.Add(word);
            }
        }
        if (list.Contains(is_suffix)) { return 1; }

        return 0;
    }
}