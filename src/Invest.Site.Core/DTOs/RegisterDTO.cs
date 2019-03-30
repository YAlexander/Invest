using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Invest.Site.Core.DTOs
{
	public class RegisterDTO
	{
		public bool IsInvestor { get; set; }

		[Required]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; } = string.Empty;

		[Required]
		[MinLength(8)]
		[DataType(DataType.Password)]
		public string Password { get; set; } = string.Empty;

		[Required]
		[DataType(DataType.Password)]
		[Compare(nameof(Password))]
		public string RePassword { get; set; } = string.Empty;

		public bool IsAgree { get; set; }

		public string FirstName { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;
		public string Patronymic { get; set; } = string.Empty;

		[DataType(DataType.PhoneNumber)]
		public string Phone { get; set; } = string.Empty;

		public bool Subscribe { get; set; }
	}
}
