using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
	class SepetManager
	{
		//name convertion isimlendirme kural E büyük
		public void Ekle(Urun urun)
		{
			Console.WriteLine("Tebrikler. Sepete eklendi:"+urun.Adi);
		}

		// üst kısım alt kısımdan clean kod olarak daha iyii
		public void Ekle2(string urunAdi,string aciklama,double fiyat)
		{
			Console.WriteLine("Tebrikler.Sepete eklendi:"+urunAdi);
		}
	}
}
