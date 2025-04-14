using System;
using System.Linq;

public class Solution {
    public string[] solution(string[] str_list) {
                
        foreach(int i in Enumerable.Range(0, str_list.Length))
        {
            if(str_list[i] == "l") return str_list.Take(i).ToArray();
            if(str_list[i] == "r") return str_list.Skip(i+1).ToArray();
        }           
        return new string[] {};
    }
}