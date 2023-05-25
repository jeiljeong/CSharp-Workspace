using System;

public class Solution {
    public int[] solution(int num, int total) {
        List<int> numList = new List<int>();
        // 나누어 떨어지는 경우, 기준인덱스(중앙값)값 == (tatal / num)
        if (total % num == 0) {
            // start 인덱스
            int startVal = (total / num) - num / 2;
            for (int i = 0; i < num; i++) {
                numList.Add(startVal++);
            }
        }
        // 아닌 경우, 기준인덱스(num / 2)값 == total // num
        else {
            int startVal = ((total / num) + 1) - num / 2;
            for (int i = 0; i < num; i++) {
                numList.Add(startVal++);
            }
        }

        int[] num = new int[] {};
        
        return numList.ToArray();
    }
}