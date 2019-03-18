using System;
using Abstractions.Codes;

namespace Domain.Entities
{
	public abstract class BaseEntity : IEntity
	{
		/// <summary>
		/// Record Id
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Record created date
		/// </summary>
		public DateTime Created { get; } = DateTime.UtcNow;

		/// <summary>
		/// Mark record as deleted
		/// </summary>
		public bool IsDeleted { get; set; }
	}
}
