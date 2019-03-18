using System;

namespace Abstractions.Entities
{
	public interface IEntity
	{
		/// <summary>
		/// Record Id
		/// </summary>
		long Id { get; set; }

		/// <summary>
		/// Record created
		/// </summary>
		DateTime Created { get; }

		/// <summary>
		/// Mark record as deleted
		/// </summary>
		bool IsDeleted { get; set; }
	}
}
