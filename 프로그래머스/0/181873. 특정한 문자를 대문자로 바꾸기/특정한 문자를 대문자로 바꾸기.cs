using System;
using System.Text;

public class Solution {
    public string solution(string my_string, string alp) {
        StringBuilder sb = new StringBuilder(my_string);
        
        for(int i = 0; i < sb.Length; i++)
        {
            if(sb[i] == alp[0])
               sb[i] = char.ToUpper(sb[i]);
        }
        
        return sb.ToString();
    }
}