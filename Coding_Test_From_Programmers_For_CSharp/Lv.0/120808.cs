using System;
using System.Collections.Generic;
using System.Linq;

//Lv.0 : 분수의 덧셈
public class Solution_120808
{
    public int[] solution(int numer1, int denom1, int numer2, int denom2)
    {
        List<int> list = new List<int>();
        int result_Numer;
        int result_Denom;
        int multi1;
        int multi2;
        int[] result;
        int x = 1;
        while (true)
        {
            if (x % denom1 == 0 && x % denom2 == 0)  //최소 공배수 구하기.
            {
                result_Denom = x;
                break;
            }
            x++;
        }
        multi1 = x / denom1;
        multi2 = x / denom2;

        result_Numer = multi1 * numer1 + multi2 * numer2;

        // [result_Numer,result_Denom]
        int count = (result_Numer < result_Denom) ? result_Denom : result_Numer;
        x = 1;
        while (x <= count)
        {
            if ((result_Numer % x == 0) && (result_Denom % x == 0))  //최대공약수 구하기
            {
                list.Add(x);
            }
            x++;
        }

        int c = list.Max();
        result_Numer = result_Numer / c;
        result_Denom = result_Denom / c;

        result = new int[] { result_Numer, result_Denom };

        return result;

    }
}