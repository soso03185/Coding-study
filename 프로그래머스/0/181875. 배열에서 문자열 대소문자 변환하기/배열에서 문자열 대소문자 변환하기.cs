using System;
using System.Linq;

public class Solution {
    public string[] solution(string[] strArr) {
      
        return strArr.Select((v, i) => i % 2 != 0 ? v.ToUpper() : v.ToLower()).ToArray();
    }
}