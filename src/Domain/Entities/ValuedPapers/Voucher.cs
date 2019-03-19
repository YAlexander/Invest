using Domain.Codes;

namespace Domain.Entities.ValuedPapers
{
	public class Voucher : ValuedPaper
	{
		public override string Code { get; } = ValuedPaperCode.Voucher.Code;
	}
}
