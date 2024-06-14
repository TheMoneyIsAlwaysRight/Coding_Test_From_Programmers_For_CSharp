using System;

//Lv.0 : 주사위 게임 1
public class Solution_181839
{
    public int solution(int a, int b)
    {
        if (a % 2 != 0 && b % 2 != 0) { return (int)(Math.Pow(a, 2) + Math.Pow(b, 2)); }
        else if (a % 2 != 0 && b % 2 == 0) { return 2 * (a + b); }
        else if (a % 2 == 0 && b % 2 != 0) { return 2 * (a + b); }
        else { return Math.Abs(a - b); }
    }
}