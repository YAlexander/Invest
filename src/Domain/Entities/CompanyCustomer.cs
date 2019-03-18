namespace Domain.Entities
{
	public class CompanyCustomer : Customer
	{
		public override bool IsCompany { get; set; } = true;

		public string CompanyName { get; set; }
	}
}
