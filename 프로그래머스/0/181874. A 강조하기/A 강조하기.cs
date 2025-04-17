using System;
using System.Text;

public class Solution {
    public string solution(string myString) {
        StringBuilder sb = new StringBuilder(myString);

        for (int i = 0; i < sb.Length; i++) {
            if (sb[i] == 'a') {
                sb[i] = 'A';
            }
            else if (char.IsUpper(sb[i]) && sb[i] != 'A') {
                sb[i] = char.ToLower(sb[i]);
            }
        }

        return sb.ToString();
    }
}
