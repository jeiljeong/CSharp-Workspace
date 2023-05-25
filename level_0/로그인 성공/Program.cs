using System;

public class Solution {
    public string solution(string[] id_pw, string[,] db) {
        string answer = "";

        var id = id_pw[0];
        var pw = id_pw[1];
        for (int i = 0; i < db.Length / 2; i++) {
            var dbId = db[i, 0];
            var dbPw = db[i, 1];
            // ID 일치, PW 일치
            if (id.Equals(dbId) && pw.Equals(dbPw)) {
                answer = "login";
                break;
            }
            // ID 일치, PW 불일치
            else if (id.Equals(dbId) && !pw.Equals(dbPw)) {
                answer = "wrong pw";
                break;
            }
            // ID 불일치
        }
        Console.WriteLine("");
        return answer.Equals("") ? "fail" : answer;
    }
}