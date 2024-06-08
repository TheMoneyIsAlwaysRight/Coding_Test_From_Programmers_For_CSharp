using System;

//Lv.0 : 문자 리스트를 문자열로 변환하기
public class Solution_181941
{
    public string solution(string[] arr)
    {
        string answer = "";
        foreach (string word in arr)
        {
            answer += word;
        }
        return answer;
    }
}