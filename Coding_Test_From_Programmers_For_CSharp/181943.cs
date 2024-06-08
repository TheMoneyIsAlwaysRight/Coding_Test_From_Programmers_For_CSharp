using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


/*
 * 문자열 겹쳐쓰기 
 */
public class Solution
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


    public static void Main()
    {
        Solution instance = new Solution();
        string my_string = "He11oWor1d";
        string overwrite_string = "lloWorl";
        int s = 2;
        string result = instance.solution(my_string, overwrite_string, s);

        Console.WriteLine($"{result}");
    }
}
