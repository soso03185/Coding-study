using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        List<int> stk = new List<int>();
        
        int i = 0;
        
        while(i < arr.Length)
        {
            if(stk.Count == 0) stk.Add(arr[i++]);
            else
            {
                int lastIndex = stk[stk.Count-1];
                
                if(lastIndex == arr[i]) 
                {
                    stk.RemoveAt(stk.Count-1);
                    i++;
                }
                else
                    stk.Add(arr[i++]);
            }
        }
        
        return stk.Count != 0 ? stk.ToArray() : new[] {-1};        
    }
}