using System;
using System.Text;


// Lv. 0: 글자 이어 붙여 문자열 만들기
public class Solution_181915
{
    public string solution(string my_string, int[] index_list)
    {
        StringBuilder result_ = new StringBuilder();

        foreach (int index in index_list)
        {
            result_.Append(my_string[index]);
        }

        return result_.ToString();
    }
}