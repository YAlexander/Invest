using Abstractions.Entities;
using Domain.Codes;

namespace Domain.Entities.ValuedPapers
{
	public abstract class ValuedPaper : BaseEntity, IValuedPaper
	{
		/// <summary>
		/// Valued paper type code <see cref="ValuedPaperCode"/>
		/// </summary>
		public abstract string Code { get; }

		/// <summary>
		/// Valued parer series (is part of Number)
		/// </summary>
		public string? Series { get; set; }

		/// <summary>
		/// Valued paper number (is part of Number)
		/// </summary>
		public int Number { get; set; }

		/// <summary>
		/// Valued paper issuer name
		/// </summary>
		public string? Issuer { get; set; }
	}
}
