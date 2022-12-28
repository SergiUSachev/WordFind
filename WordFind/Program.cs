using System.Globalization;

namespace WordFind
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<int, string> wordsDick = new Dictionary<int, string>();
			int[] ids = new int[] { 0,1,2,3,4,5};
			string[] words = new string[] {"esli", "ne", "goluboy", "narisuy", "vagon","drugoy"};

			for (int i = 0; i < ids.Length; i++)
			{
				wordsDick.Add(ids[i], words[i]);	
			}
			
			string wordToSearch = Console.ReadLine();
			bool foundFlag = false;

			foreach (var item in wordsDick)
			{

				if (wordToSearch==item.Value)
				{
					Console.WriteLine(item.Key);
					foundFlag =true;
				}
				
			}

			if (!foundFlag)
			{
				Console.WriteLine("Нет слова");
			}

		}
	}
}