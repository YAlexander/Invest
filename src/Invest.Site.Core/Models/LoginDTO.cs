﻿using System.ComponentModel.DataAnnotations;

namespace Invest.Site.Core.Models
{
	public class LoginDTO
	{
		[Required]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; } = string.Empty;

		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; } = string.Empty;
	}
}
