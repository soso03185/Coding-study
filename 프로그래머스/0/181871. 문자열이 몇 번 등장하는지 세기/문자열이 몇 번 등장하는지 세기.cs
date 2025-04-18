using System;

public class Solution {
    public int solution(string myString, string pat) {       
        int answer = 0;
        
        for(int i = 0; i <= myString.Length - pat.Length; i++)
        {
            int cnt = 0;
            
            while(myString[i + cnt] == pat[cnt])
            {
                cnt++;
                
                if(cnt >= pat.Length)
                {
                    answer++;
                    break;
                }                    
            }
        }
        return answer;
    }
}