using System.Globalization;

namespace WordFind
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, string> wordsDick = new Dictionary<string, string>();
			string[] words = new string[] {"dog", "cat", "goat", "cock"};
			string[] wordsMeaning = new string[] {"bark-bark", "meow", "beyaa", "kokuorekou"};

			for (int i = 0; i < wordsMeaning.Length; i++)
			{
				wordsDick.Add(words[i], wordsMeaning[i]);	
			}

			string wordToSearch = Console.ReadLine();

			if (wordsDick.ContainsKey(wordToSearch))
			{
			Console.WriteLine(wordsDick[wordToSearch]);
			}
			else
			{
				Console.WriteLine("Нет такого слова");
			}
		}
	}
}