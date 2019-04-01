namespace Invest.Site.Core.Models
{
	public class AddressDTO
	{
		public long Id { get; set; }

		public string CountryCode { get; set; } = string.Empty;

		public string Region { get; set; } = string.Empty;

		public string City { get; set; } = string.Empty;

		public string Street { get; set; } = string.Empty;

		public string PostCode { get; set; } = string.Empty;

		public string? ZipExt { get; set; }
	}
}
