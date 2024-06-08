using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


/*
 * 문자열 겹쳐쓰기 
 */
public class Solution_181943
{
    public string solution(string my_string, string overwrite_string, int s)
    {
        string answer = "";

        List<char> prev_List = my_string.ToCharArray().ToList<Char>();
        List<char> new_List = overwrite_string.ToCharArray().ToList<Char>();

        int x = 0;
        while (prev_List.Count > 0)
        {
            if (x < s)
            {
                answer += prev_List[0];
                prev_List.RemoveAt(0);
            }
            else if (x >= s)
            {
                if (new_List.Count > 0)
                {
                    answer += new_List[0];
                    new_List.RemoveAt(0);
                    prev_List.RemoveAt(0);
                }
                else
                {
                    answer += prev_List[0];
                    prev_List.RemoveAt(0);
                }
            }
            x++;
        }
        return answer;

    }

}
