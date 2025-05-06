using System;
using System.Linq;

public class Solution {
    public int solution(int[] citations) {
        var arr = citations.OrderByDescending(o=>o).ToArray();
        int Cnt = 0;
        int revCnt = 0;
        
        foreach(var child in arr)
        {
            if(child > Cnt) Cnt++; 
            else revCnt--;
        }
        Console.WriteLine($"Cnt = {Cnt} , revCnt = {revCnt} ");
        if(Cnt == 0) return 0;
        return Cnt + revCnt >= 0 ? Cnt : --Cnt;
    }
}