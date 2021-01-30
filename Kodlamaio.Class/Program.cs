using System;

namespace Kodlamaio.Class
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Marketteki ürünleri listeleme");

			Urun urun1 = new Urun();
			urun1.Adi = "Defter";
			urun1.Adet = 1000;
			urun1.Fiyat = 5;
			urun1.SeriNo = 1234567;
			urun1.Aciklama = "Lise defteri";

			Urun urun2 = new Urun();
			urun2.Adi = "Kalem";
			urun2.Adet = 1000;
			urun2.Fiyat = 2;
			urun2.SeriNo = 9876316;
			urun2.Aciklama = "Kalem";

			Urun urun3 = new Urun();
			urun3.Adi = "Kağıt";
			urun3.Adet = 5000;
			urun3.Fiyat = 10;
			urun3.SeriNo = 2468125;
			urun3.Aciklama = "A4 Kağıt";


			Urun[] uruns = new Urun[] { urun1, urun2, urun3 };

			Console.WriteLine("For döngüsü:");
			for (int i = 0; i < uruns.Length; i++)
			{
				Console.WriteLine(
					"Adi:"+uruns[i].Adi+" "+
					"Adet Miktari:"+uruns[i].Adet+" "+
					"Fiyat:"+uruns[i].Fiyat+"TL "+
					"Seri no:"+uruns[i].SeriNo+" "+
					"Aciklaması:"+uruns[i].Aciklama);
			}

			Console.WriteLine("--------------------");

			Console.WriteLine("Foreach döngüsü:");
			foreach (Urun urun in uruns)
			{
				Console.WriteLine(
					urun.Adi+" "+
					urun.Adet+" "+
					urun.Fiyat+" "+
					urun.SeriNo+" "+
					urun.Aciklama);
			}

			Console.WriteLine("--------------------");
			Console.WriteLine("While döngüsü:");

			int j = 0;
			while (j<uruns.Length)
			{
				Console.WriteLine(
					uruns[j].Adi+" "+
					uruns[j].Adet+" "+
					uruns[j].Fiyat+" "+
					uruns[j].SeriNo+" "+
					uruns[j].Aciklama);
				j++;
			}

		}
	}
}
