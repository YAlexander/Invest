using Domain.Codes;

namespace Domain.Entities.ValuedPapers
{
	public class Share : ValuedPaper
	{
		public override string Code { get; } = ValuedPaperCode.Share.Code;
	}
}
