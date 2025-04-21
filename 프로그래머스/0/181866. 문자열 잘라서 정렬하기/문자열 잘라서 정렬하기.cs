using System;
using System.Linq;

public class Solution {
    public string[] solution(string myString) {       
        return myString.Split('x').Where(w => w.Length > 0).OrderBy(o => o).ToArray();
    }
}