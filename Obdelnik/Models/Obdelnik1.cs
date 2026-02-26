namespace Obdelnik.Models
{
	public class Obdelnik1
	{
		public int StranaA { get; set; }
		public int StranaB { get; set; }
		public int Obvod { get; private set; }
		public int Obsah { get; private set; }
		public double Uhlopricka { get; private set; }

		private void SpoctoObsah()
		{
			Obsah = StranaA * StranaB;
		}

		private void SpocitejObvod()
		{
			Obvod = 2 * (StranaA + StranaB);
		}

		private void SpocitejUhlopricku()
		{
			Uhlopricka = Math.Sqrt(StranaA * StranaA + Math.Pow(StranaB, 2));
		}

		public void SpocitejVse()
		{
			SpoctoObsah();
			SpocitejObvod();
			SpocitejUhlopricku();
		}
	}
}
