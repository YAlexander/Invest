using Abstractions.Entities;

namespace Domain.Entities
{
	public class Address : BaseEntity, IAddress
	{
		/// <summary>
		/// Country 2-symbol code
		/// </summary>
		public string CountryCode { get; set; }

		/// <summary>
		/// Region name
		/// </summary>
		public string Region { get; set; }

		/// <summary>
		/// City name
		/// </summary>
		public string City { get; set; }

		/// <summary>
		/// Street
		/// </summary>
		public string Street { get; set; }

		/// <summary>
		/// Post code
		/// </summary>
		public string PostCode { get; set; }

		/// <summary>
		/// Extension for Zip code
		/// </summary>
		public string ZipExt { get; set; }
	}
}
