using System;
using System.Text;

//반례찾기
public class Solution_181841
{
    public string solution(string[] str_list, string ex)
    {
        StringBuilder result = new StringBuilder();
        for (int x = 0; x < str_list.Length; x++)
        {
            string subWord = str_list[x].Substring((str_list.Length - ex.Length));
            if (subWord != ex)
            {
                result.Append(str_list[x]);
            }
        }

        return result.ToString();
    }
}