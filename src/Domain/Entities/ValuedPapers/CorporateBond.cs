using Domain.Codes;

namespace Domain.Entities.ValuedPapers
{
	public class CorporateBond : ValuedPaper
	{
		public override string Code { get; } = ValuedPaperCode.CorporateBond.Code;
	}
}
