using System;

namespace Domain.Entities
{
	public class PrivateCustomer : Customer
	{
		public override bool IsCompany { get; set; } = false;

		public string FirstName { get; set; } = string.Empty;
		public string Patronymic { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;
	}
}