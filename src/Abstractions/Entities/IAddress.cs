using System;
using System.Collections.Generic;
using System.Text;

namespace Abstractions.Entities
{
	public interface IAddress : IEntity
	{
		/// <summary>
		/// 2-letter country code
		/// </summary>
		string Country { get; set; }

		/// <summary>
		/// Region name
		/// </summary>
		string Region { get; set; }

		/// <summary>
		/// City name
		/// </summary>
		string City { get; set; }

		/// <summary>
		/// Street
		/// </summary>
		string Street { get; set; }

		/// <summary>
		/// Post code
		/// </summary>
		string PostCode { get; set; }

		/// <summary>
		/// Extension for Zip code
		/// </summary>
		string ZipExt { get; set; }
	}
}
