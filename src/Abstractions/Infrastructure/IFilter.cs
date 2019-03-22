using System.Collections.Generic;

namespace Abstractions.Infrastructure
{
	public interface IFilter
	{
		int PageIndex { get; set; }

		int PageSize { get; set; }

		string OrderBy { get; set; }

		string SortDirection { get; set; }

		Dictionary<string, object> Params { get; set; }
	}
}
