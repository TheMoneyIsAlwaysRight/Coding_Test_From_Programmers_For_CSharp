using System;

//Lv.0 : 조건 문자열
public class Solution_181934
{
    public int solution(string ineq, string eq, int n, int m)
    {
        int result;
        if (ineq == "<")
        {
            if (eq == "=")
            {
                result = (n <= m) ? 1 : 0;
            }
            else
            {
                result = (n < m) ? 1 : 0;
            }
        }
        else
        {

            if (eq == "=")
            {
                result = (n >= m) ? 1 : 0;
            }
            else
            {
                result = (n > m) ? 1 : 0;
            }
        }

        return result;
    }
}