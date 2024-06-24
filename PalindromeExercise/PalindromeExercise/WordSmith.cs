using System;
namespace PalindromeExercise
{
	public class WordSmith
	{
		public WordSmith()
		{
		}

		public bool IsAPalindrome(string input)
		{
			char[] asArray = input.ToCharArray();
			Array.Reverse(asArray);
			string reversed = new string(asArray);

			if(input == reversed)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}

