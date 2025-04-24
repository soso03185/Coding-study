using System;

public class Solution {
    public int solution(string num_str) {
        int answer = 0;
        
        foreach(var child in num_str)
        {
            answer += child - '0';
        }
        
        return answer;
    }
}