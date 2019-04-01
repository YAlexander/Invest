namespace Invest.Site.Core.Models
{
	public class CustomerDTO
	{
		public long CustomerId { get; set; }
		public bool IsCompany { get; set; }
		public bool IsCustomerVerified { get; set; }
		public bool IsInvestor { get; set; }
		public string Email { get; set; } = string.Empty;
		public bool IsEmailVerified { get; set; }
		public string? Phone { get; set; }
		public bool IsPhoneVerified { get; set; }

		// Private customer fields
		public string FirstName { get; set; } = string.Empty;
		public string Patronymic { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;

		// Business customer fields
	}
}
