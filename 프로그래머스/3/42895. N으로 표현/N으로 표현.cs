using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int N, int number) {
        if (N == number) return 1;

        var dp = new List<HashSet<int>>();
        for (int i = 0; i < 9; i++) dp.Add(new HashSet<int>());

        for (int i = 1; i <= 8; i++) {
            int repeatedN = int.Parse(new string(N.ToString()[0], i));
            dp[i].Add(repeatedN);

            for (int j = 1; j < i; j++) {
                foreach (int op1 in dp[j]) {
                    foreach (int op2 in dp[i - j]) {
                        dp[i].Add(op1 + op2);
                        dp[i].Add(op1 - op2);
                        dp[i].Add(op1 * op2);
                        if (op2 != 0) dp[i].Add(op1 / op2);
                    }
                }
            }

            if (dp[i].Contains(number)) return i;
        }

        return -1;
    }
}
