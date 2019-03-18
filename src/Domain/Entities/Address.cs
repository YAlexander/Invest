namespace Domain.Entities
{
	public class Address : BaseEntity
	{
		public int Country { get; set; }

		public string Region { get; set; }

		public string City { get; set; }

		public string Street { get; set; }

		public string Zip { get; set; }
	}
}
