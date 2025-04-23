using System;
using System.Linq;

public class Solution {
    public int solution(string[] strArr) {
        int max = 0; 
        for(int i = 0; i <  50; i++)
        {
            int cnt = strArr.Where(w => w.Length == i).ToArray().Length;
            max = Math.Max(cnt, max);
        }
        
        return max;
    }
}