using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Lv.1 : 정수 내림차순의 배치하기
public class Solution_12933
{
    public long solution(long n)
    {
        string word = n.ToString();
        StringBuilder result;

        List<char> list = word.ToCharArray().ToList<char>();

        bool isSorted = false;

        while (!isSorted)
        {
            isSorted = true;
            for (int x = 0; x < list.Count; x++)
            {
                if (x + 1 >= list.Count) { break; }
                if (list[x] < list[x + 1])
                {
                    list.Add(list[x]);
                    list.RemoveAt(x);
                    isSorted = false;
                    break;
                }
            }
        }
        result = new StringBuilder();
        foreach (char x in list)
        {
            result.Append(x);
        }

        return Int64.Parse(result.ToString());
    }
}