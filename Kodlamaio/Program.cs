using System;

namespace Kodlamaio
{
	class Program
	{
		

		static void Main(string[] args)
		{
			Kurs kurs = new Kurs();

			kurs.KursAdi = "java";
			kurs.IzlenmeOranı = 54;
			kurs.Egitmen = "kaan akyüz";

			Kurs kurs1 = new Kurs();
			kurs1.KursAdi = "python";
			kurs1.IzlenmeOranı = 14;
			kurs1.Egitmen = "ozan akyüz";

			Kurs kurs2 = new Kurs();
			kurs2.KursAdi = "c#";
			kurs2.IzlenmeOranı = 24;
			kurs2.Egitmen = "emine akyüz";

			Kurs[] kurslar = new Kurs[] { kurs,kurs1,kurs2 };

			foreach (var item in kurslar)
			{
				Console.WriteLine(item.KursAdi);
			}

		}
	}

	class Kurs
	{
		public string KursAdi { get; set; }

		public string Egitmen { get; set; }

		public int IzlenmeOranı { get; set; }

	}

	
}
