using System;

public class Solution {
    public int solution(int[,] arr) {
        int length = arr.GetLength(0);
        
        for(int i = 0; i < length; i++)
        {
            for(int j = 0; j < length; j++)
            {
                if(arr[i,j] != arr[j,i]) return 0;
            }
        }
        return 1;
    }
}