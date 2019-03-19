namespace Domain.Entities
{
	public class Investment : BaseEntity
	{
		public string Code { get; set; }

		public string Title { get; set; }
		public string Description { get; set; }

		public string CurrencyCode { get; set; }
		public decimal TotalAmount { get; set; }
		public decimal? SharePrice { get; set; }
	}
}
