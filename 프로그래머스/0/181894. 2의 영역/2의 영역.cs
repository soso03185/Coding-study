using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {        
        int first = -1;
        int last = -1;
        
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] == 2) 
            {
                first = i;
                break;
            }
        }
        for(int i = arr.Length -1; i >= 0; i--)
        {
            if(arr[i] == 2) 
            {
                last = i;
                break;
            }
        }
        
        if(first == -1)
            return new int[] { -1 };         
        else
        {                    
            return Enumerable.Range(first, last - first + 1)
                    .Select(i => arr[i])
                    .ToArray();
        }
    }
}