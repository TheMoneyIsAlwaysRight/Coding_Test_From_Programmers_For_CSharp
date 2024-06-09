using System;

//Lv.0 : 등차수열의 특정한 항만 더하기
public class Solution_181931
{
    public int solution(int a, int d, bool[] included)
    {
        int answer = 0;

        int q = 0;
        foreach (bool x in included)
        {

            if (x == false)
            {
                q++;
                continue;
            }

            answer += a + (d * q);
            q++;

        }
        return answer;
    }
}