namespace Domain.Entities
{
	public class BusinessCustomer : Customer
	{
		public override bool IsCompany { get; set; } = true;

		public string CompanyName { get; set; } = string.Empty;
	}
}
