using System.ComponentModel.DataAnnotations;

namespace Obdelnik.Models
{
	public class ObdelnikForm
	{
		[Required]
		[Range(0, int.MaxValue, ErrorMessage = "Strana A musí být nezáporné číslo.")]
		public int StranaA { get; set; }

		[Range(0, int.MaxValue, ErrorMessage = "Strana B musí být nezáporné číslo.")]
		public int StranaB { get; set; }
	}
}
