using System;
using System.Text.RegularExpressions;

public class Solution
{
	public int solution(string my_string)
	{
		int answer = 0;

		string temp = Regex.Replace(my_string, @"\D", "");
		for (int i = 0; i < temp.Length; i++)
		{
			answer += int.Parse(temp[i].ToString());
		}

		return answer;
	}
}