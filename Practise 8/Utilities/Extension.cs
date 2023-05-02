using System;
using Practise_8;
namespace Practise_8.Utilities
{
	public static class Extension
	{
		public static int MatchCount(this string word, string searchTerm)
		{
			int count = 0;
			string[] occurences = word.Split(" ");
			for (int i = 0; i < occurences.Length; i++)
			{
				if (occurences[i] == searchTerm)
				{
					count++;
				}
			}
			return count;

		}
	}
}

