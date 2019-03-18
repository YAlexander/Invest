namespace Domain.Entities
{
	public abstract class Customer : BaseEntity
	{
		public abstract bool IsCompany { get; set; }

		public bool IsCustomerVerified { get; set; }

		public bool IsInvestor { get; set; }

		public string Email { get; set; }

		public bool IsEmailVerified { get; set; }

		public string Phone { get; set; }

		public bool IsPhoneVerified { get; set; }
	}
}
