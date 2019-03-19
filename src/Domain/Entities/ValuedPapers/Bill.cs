using Domain.Codes;

namespace Domain.Entities.ValuedPapers
{
	public class Bill : ValuedPaper
	{
		public override string Code { get; } = ValuedPaperCode.Bill.Code;
	}
}
