using System;
using System.Collections.Generic;
using System.Text;

namespace CS.Sharp.Ders._29
{
	public class Hayvanlar : Canlılar
	{
		protected void Adaptasyon()
		{
			Console.WriteLine("Hayvalar adaptasyon kurabilir");
		}
	}

	public class Sürüngenler : Hayvanlar
	{	
		public Sürüngenler()
        {
			base.Adaptasyon();
			base.Beslenme();
			base.Boşaltım();
			base.Solunum();
		}
		public void SoğukkanlıDavranıs()
		{
			Console.WriteLine("Sürüngenler hava soğukkken daha yavaş hareket ederler.");
		}
	}

	public class Kuslar : Hayvanlar
	{
		public Kuslar()
		{
			base.Adaptasyon();
			base.Beslenme();
			base.Boşaltım();
			base.Solunum();
		}
		public void Ucmak()
		{
			Console.WriteLine("Kuslar ucar");
		}
	}
}
