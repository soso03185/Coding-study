using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] answers) {
        int[] num1 = new int[] {1,2,3,4,5};
        int[] num2 = new int[] {2,1,2,3,2,4,2,5};
        int[] num3 = new int[] {3,3,1,1,2,2,4,4,5,5};
        
        int[] arr = new int[3];
        
        for(int i = 0; i < answers.Length; i++)
        {
            if(answers[i] == num1[i % num1.Length]) arr[0]++;
            if(answers[i] == num2[i % num2.Length]) arr[1]++;
            if(answers[i] == num3[i % num3.Length]) arr[2]++;
        }        
        int max = arr.Max();
        arr = arr.Select((value,index) => new {value,index}).Where(w => w.value == max).Select(s => s.index+1).ToArray();
        
        if(max == 0) 
            return new int[] {arr.Length-1};      
        
        return arr;
    }
}