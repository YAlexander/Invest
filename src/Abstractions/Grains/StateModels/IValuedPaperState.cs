using System.Collections.Generic;

namespace Abstractions.Grains.StateModels
{
	public interface IValuedPaperState
	{
		Dictionary<string, object> Details { get; set; }
	}
}
