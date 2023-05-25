using System;
using System.Linq;

public class Solution {
    public string[] solution(string[] strArr) {
        string[] answer = strArr.Where(x => !x.Contains("ad")).ToArray();
        return answer;
    }
}