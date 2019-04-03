using Domain.Entities.ValuedPapers;
using Invest.Backend.Grains.GrainImplementations.StateModels;

namespace Invest.Backend.Grains.Helpers
{
	public static class ValuedPapersMapper
	{
		public static ValuedPaperState Map (this Bill valuedPaper)
		{
			ValuedPaperState state = new ValuedPaperState();
			//state.Details;

			return state;
		}

		public static ValuedPaperState Map (this Stock valuedPaper)
		{
			ValuedPaperState state = new ValuedPaperState();
			//state.Details;

			return state;
		}

		public static ValuedPaperState Map (this ConvertibleBond valuedPaper)
		{
			ValuedPaperState state = new ValuedPaperState();
			//state.Details;

			return state;
		}

		public static ValuedPaperState Map (this CorporateBond valuedPaper)
		{
			ValuedPaperState state = new ValuedPaperState();
			//state.Details;

			return state;
		}

		public static ValuedPaperState Map (this Share valuedPaper)
		{
			ValuedPaperState state = new ValuedPaperState();
			//state.Details;

			return state;
		}

		public static ValuedPaperState Map (this Voucher valuedPaper)
		{
			ValuedPaperState state = new ValuedPaperState();
			//state.Details;

			return state;
		}
	}
}
