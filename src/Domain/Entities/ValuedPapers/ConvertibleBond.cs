using Domain.Codes;

namespace Domain.Entities.ValuedPapers
{
	public class ConvertibleBond : CorporateBond
	{
		public override string Code { get; } = ValuedPaperCode.ConvertibleBond.Code;
	}
}
