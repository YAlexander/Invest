using Abstractions.Entities;

namespace Domain.Entities
{
	public class Address : BaseEntity, IAddress
	{
		public string Country { get; set; }

		public string Region { get; set; }

		public string City { get; set; }

		public string Street { get; set; }

		public string PostCode { get; set; }

		public string ZipExt { get; set; }
	}
}
