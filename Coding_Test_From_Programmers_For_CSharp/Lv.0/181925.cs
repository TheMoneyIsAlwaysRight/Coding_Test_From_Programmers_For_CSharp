using System;
using System.Text;

//Lv.0 : 수 조작하기
public class Solution
{
    public string solution(int[] numLog)
    {
        StringBuilder result = new StringBuilder();  //stringBuilder (x) -> StringBuilder (O)

        int prevNumber = numLog[0];

        foreach (int x in numLog)
        {
            if (x == prevNumber) { continue; }

            if (x != prevNumber)
            {
                int y = Math.Abs(x - prevNumber);

                switch (y)
                {
                    case 1:
                        if (x > prevNumber) { result.Append("w"); }
                        else { result.Append("s"); }
                        break;
                    case 10:
                        if (x > prevNumber) { result.Append("d"); }
                        else { result.Append("a"); }
                        break;
                }

                prevNumber = x;
            }

        }

        return result.ToString();

    }
}