using System;
using System.Linq;
using System.Text;

public class Solution {
    public string solution(int[] numbers) {
        
        // 숫자를 문자열로 변환
        var strNumbers = numbers.Select(n => n.ToString()).ToArray();

        // 핵심: 커스텀 비교 -> (b + a).CompareTo(a + b)
        Array.Sort(strNumbers, (a, b) => (b + a).CompareTo(a + b));

        // 0만 있는 경우: "000" → "0"
        if (strNumbers[0] == "0") return "0";

        // 결과 조합
        return string.Join("", strNumbers);
    }
}