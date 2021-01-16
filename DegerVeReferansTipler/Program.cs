using System;

namespace DegerVeReferansTipler
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			int sayi1 = 10;
			int sayi2 = 30;
			sayi1 = sayi2;
			sayi2 = 65;
			Console.WriteLine(sayi1);
			// int decimal float double bool bunlar değer tiptir
			// array class interface bunlar ise referans tiptir
			/*
			 
			değer tipler stackta tutulur.
			new denildiği anda heap kısmında bi alan açılır.
			örn:
			int[] sayilar1=new int[]{10,20,30};

			stack			heap
			sayilar1-------> [10,20,30]
			sayilar2-------> [100,200,300]
			sayilar1=sayilar2 yaparsak
			sayilar1'in referans numarası sayilar2'nın referans
			numarası demektir ARTIK.
			sayilar[0]=999;

			yazılımda en önemli olay sürdürülebilirliktir.

			 */
		}
	}
}
