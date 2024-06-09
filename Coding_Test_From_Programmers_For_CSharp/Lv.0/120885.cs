using System;

//Lv.0 이진수 더하기
public class Solution_120885
{
    public string solution(string bin1, string bin2)
    {

        int bin_1 = Convert.ToInt32(bin1, 2); //2진수 문자열(예: "10101")을 10진수 정수형 값으로 변환.
        int bin_2 = Convert.ToInt32(bin2, 2); 

        int result = bin_1 + bin_2;

        string answer = Convert.ToString(result, 2); // 10진수 정수형 int형 result 값을 받고 이를 2진수로 문자열로 변환.

        return answer;
    }
}