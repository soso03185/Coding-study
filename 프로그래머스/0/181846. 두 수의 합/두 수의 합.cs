using System;
using System.Text;

public class Solution {
    public string solution(string a, string b) {
        StringBuilder sb = new StringBuilder();

        int Alength = a.Length - 1;
        int Blength = b.Length - 1;
        int carry = 0;

        while (Alength >= 0 || Blength >= 0 || carry > 0)
        {
            int Avalue = Alength >= 0 ? a[Alength--] - '0' : 0;
            int Bvalue = Blength >= 0 ? b[Blength--] - '0' : 0;

            int sum = Avalue + Bvalue + carry;
            carry = sum / 10;
            sb.Insert(0, sum % 10);
        }

        return sb.ToString();
    }
}
