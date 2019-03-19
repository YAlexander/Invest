using System;

namespace Domain.Entities
{
	public class PrivateCustomer : Customer
	{
		public override bool IsCompany { get; set; } = false;

		public string FirstName { get; set; }
		public string Patronymic { get; set; }
		public string LastName { get; set; }
	}
}