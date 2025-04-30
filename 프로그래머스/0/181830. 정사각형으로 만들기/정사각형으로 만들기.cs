using System;
using System.Collections.Generic;

public class Solution {
    
    public int[,] Cal(int row, int col, int[,] arr)
    {
        int max = Math.Max(row,col);
        int[,] answer = new int[max, max];
        
        for(int i = 0; i < row; i++)
        {
            for(int j = 0; j < col; j++)
                answer[i,j] = arr[i,j];
        }   
        return answer;    
    }
    
    public int[,] solution(int[,] arr) {
        int rowLength = arr.GetLength(0);
        int colLength = arr.GetLength(1);
        
        if(rowLength == colLength) return arr;
        else
        {
            if(rowLength > colLength)
               return Cal(rowLength,colLength, arr);
            else
               return Cal(rowLength,colLength, arr);
        }
        return null;
    }
}