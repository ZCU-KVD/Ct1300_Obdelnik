namespace Obdelnik.Models
{
	public class Obdelnik2
	{
		public Obdelnik2()
		{

		}
		public Obdelnik2(int stranaA, int stranaB)
		{
			StranaA = stranaA;
			StranaB = stranaB;
		}
		private int stranaA;
		private int stranaB;
		private int NormalizujStranu(int strana) => Math.Max(0, strana);
		public int StranaA { get => stranaA; set => stranaA = NormalizujStranu(value); }
		public int StranaB { get => stranaB; set => stranaB = NormalizujStranu(value); }
		public int Obvod => 2 * (StranaA + StranaB);
		public int Obsah => StranaA * StranaB;
		public double Uhlopricka => Math.Sqrt(StranaA * StranaA + Math.Pow(StranaB, 2));
	}
}
