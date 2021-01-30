using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
	class BasvuruManager
	{
		// method injection
		public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService) //hangi kredi tipini girersem o çalışır
		{
			//Başvuran bilgilerini değerlendirme
			/*
			KonutKrediManager konutKrediManager = new KonutKrediManager();
			konutKrediManager.Hesapla(); // bu kısım doğru değil
			*/
			krediManager.Hesapla();
			loggerService.Log();

		}
		public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
		{
			foreach (var kredi in krediler)
			{
				kredi.Hesapla();
			}
		}
	}
}
