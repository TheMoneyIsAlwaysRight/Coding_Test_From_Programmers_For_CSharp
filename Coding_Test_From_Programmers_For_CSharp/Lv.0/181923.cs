using System;
using System.Collections.Generic;
using System.Linq;


//반례 찾아야함
public class Solution_181923
{
    public int[] solution(int[] arr, int[,] queries)
    {
        List<int> backUp = new List<int>();
        List<int> querie_List = new List<int>();
        List<int> result = new List<int>();

        for (int x = 0; x < queries.GetLength(1); x++)
        {
            for (int y = 0; y < queries.GetLength(0); y++)
            {
                querie_List.Add(queries[x, y]);
            }

            for (int z = querie_List[0]; z <= querie_List[1]; z++)
            {
                backUp.Add(arr[z]);
            }
            if (backUp.Exists(item => item > querie_List[2]))
            {
                backUp.Sort();
                result.Add(backUp.FirstOrDefault(item => item > querie_List[2]));
                backUp.Clear();
                querie_List.Clear();
            }
            else
            {
                result.Add(-1);
                backUp.Clear();
                querie_List.Clear();
            }

        }
        return result.ToArray();
    }
}