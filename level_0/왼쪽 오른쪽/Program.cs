using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] str_list) {
        var answer = new List<string>();

        for (int i = 0; i < str_list.Length; i++) {
            if (str_list[i].Equals(value: "l")) {
                return answer.ToArray();
            }
            else if (str_list[i].Equals(value: "r"))
            {
                answer = new List<string>();
                for (int j = i + 1; j < str_list.Length; j++) {
                    answer.Add(str_list[j]);
                }
                return answer.ToArray();
            }
            answer.Add(str_list[i]);
        }

        return answer.Count == str_list.Length ? new string[] {} : answer.ToArray();
    }
}