using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(string[,] clothes) {
        Dictionary<string,List<string>> dic = new Dictionary<string,List<string>>();
        int answer = 1;
        
        for(int i = 0; i < clothes.GetLength(0); i++)
        {
            string key = clothes[i,1];
            string value = clothes[i,0];
            
            if(dic.ContainsKey(key) == false)
                dic[key] = new List<string>();

            dic[key].Add(value);            
        }
        
        foreach(var child in dic)
           answer *= (child.Value.Count + 1);
        
        return answer-1;
    }
}