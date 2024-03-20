using System;
using System.Text;

public class Solution
{
    public string solution(string my_string, string letter)
    {
        string answer = "";

        string[] SplitResult = my_string.Split(letter);

        for (int i = 0; i < SplitResult.Length; i++)
        {
            answer += SplitResult[i];
        }
        return answer;
    }
}