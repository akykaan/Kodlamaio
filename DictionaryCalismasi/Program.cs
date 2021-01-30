using System;
using System.Collections.Generic;

namespace DictionaryCalismasi
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Dictionary Calismasi");

			MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

			myDictionary.Add(1,"Süt");
			myDictionary.Add(2,"Yumurta");
			myDictionary.Add(3,"Ekmek");
			myDictionary.Add(4,"Peynir");
			myDictionary.List();

		}
	}
}
