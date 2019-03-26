using System.Collections.Generic;

namespace Invest.Site.Core.DTOs
{
	public class ValuedPaperInfoDTO
	{
		public long Id { get; set; }

		/// <summary>
		/// Valued paper type code <see cref="ValuedPaperCode"/>
		/// </summary>
		public string Code { get; set; } = string.Empty;

		public string Series { get; set; } = string.Empty;

		public int Number { get; set; }

		public string Issuer { get; set; } = string.Empty;

		public List<CouponDTO> Coupons { get; set; } = new List<CouponDTO>();
	}
}
