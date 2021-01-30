using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryCalismasi
{
	class MyDictionary<Tkey, Tvalue>
	{
		Tkey[] tkeys;
		Tvalue[] tvalues;
		public MyDictionary()
		{
			tkeys = new Tkey[0];
			tvalues = new Tvalue[0];
		}
		public void Add(Tkey key, Tvalue value)
		{
			Tkey[] tempArrayK = tkeys;
			Tvalue[] tempArrayV = tvalues;

			tkeys = new Tkey[tkeys.Length + 1];
			tvalues = new Tvalue[tvalues.Length + 1];


			for (int i = 0; i < tempArrayV.Length; i++)
			{
				tvalues[i] = tempArrayV[i];
				tkeys[i] = tempArrayK[i];
			}

			tkeys[tkeys.Length - 1] = key;
			tvalues[tvalues.Length - 1] = value;

		}
		public void List()
		{
			for (int i = 0; i < tkeys.Length; i++)
			{
				Console.WriteLine(tkeys[i]+" "+tvalues[i]);
			}

		}
	}
}
