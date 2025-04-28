using System;

public class Solution {
    public int solution(int a, int b) {
       
        if(a % 2 != 0 && b % 2 != 0)
            return a * a + b * b;
        else if(a % 2 != 0 || b % 2 != 0)
            return 2 * (a + b);
        else        
            return Math.Abs(a - b);
    }
}