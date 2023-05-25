using System;

public class Solution {
    public int solution(int a, int b) {
        var val = 2 * a * b;
        var seq = Int32.Parse(a.ToString() + b.ToString());

        return val > seq ? val : seq;
    }
}