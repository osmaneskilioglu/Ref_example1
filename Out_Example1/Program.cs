using System;

namespace Out_Example1
{
	class OutParametre
	{
		int uc, bes = 0;
		// Üçe veya beşe bölünen sayıları adetini bulan metot 
		// out sayesinde sayi parametresinin değeri de geriye döner
		public int GetSayi(int n, out int sayi)
		{

			for (int i = 1; i <= n; i++)
			{

				if (i % 3 == 0)
					uc++;

				if (i % 5 == 0)
					bes++;
			}
			sayi = bes;

			// integer kısmı geriye döndürür
			return uc;
		}
	}

	class OutOrnek
	{
		static void Main()
		{
			OutParametre op = new OutParametre();
			int a, b;

			// İki değer döndürmek için ikinci argümanı out ile gönderiyoruz
			// b değişkeni GetSayi metodunda sayi değişkeninin değerlerini taşır
			a = op.GetSayi(25, out b);

			System.Console.WriteLine("Üçe bölünen sayısı: " + a);
			System.Console.WriteLine("Beşe bölünen sayısı: " + b);
		}
	}
}
		

