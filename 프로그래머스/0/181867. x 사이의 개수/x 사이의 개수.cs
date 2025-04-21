using System;
using System.Linq;

public class Solution {
    public int[] solution(string myString) { 
        string[] arr = myString.Split('x');
    
        int[] answer = new int[arr.Length];
        
        for(int i = 0; i < arr.Length; i++)
        {
            answer[i] = arr[i].Length;
        }
        return answer;
    }
}