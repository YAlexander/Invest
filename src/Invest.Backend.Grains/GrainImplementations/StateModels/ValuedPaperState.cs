using System.Collections.Generic;
using Abstractions.Grains.StateModels;

namespace Invest.Backend.Grains.GrainImplementations.StateModels
{
	public class ValuedPaperState : IValuedPaperState, IState
	{
		public Dictionary<string, object> Details { get; set; } = new Dictionary<string, object>();
	}
}
