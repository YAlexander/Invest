using Abstractions.Entities;
using Abstractions.Grains.StateModels;

namespace Invest.Backend.Grains.GrainImplementations.StateModels
{
	public class InvestmentState : IInvestmentState
	{
		private IValuedPaper? Details { get; set; }
	}
}
