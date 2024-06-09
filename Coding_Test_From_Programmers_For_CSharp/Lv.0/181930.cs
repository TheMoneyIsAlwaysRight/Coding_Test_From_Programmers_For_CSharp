using System;


//Lv 0 : 주사위 게임 2
public class Solution_181930
{
    public int solution(int a, int b, int c)
    {
        double result;

        if ((a != b) && (b != c) && (a != c))
        {
            result = a + b + c;
        }
        else if ((a == b) && (b == c))
        {
            result = (a + b + c) * (Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2)) * (Math.Pow(a, 3) + Math.Pow(b, 3) + Math.Pow(c, 3));
        }
        else
        {

            result = (a + b + c) * (Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2));
        }

        return (int)result;

    }
}