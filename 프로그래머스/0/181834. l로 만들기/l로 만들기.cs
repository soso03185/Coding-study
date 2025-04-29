using System;
using System.Text;

public class Solution {
    public string solution(string myString) {
        StringBuilder sb = new StringBuilder();

        foreach(var child in myString)
        {
            if(child < 'l') sb.Append('l');
            else            sb.Append(child);
        }
        return sb.ToString();
    }
}
