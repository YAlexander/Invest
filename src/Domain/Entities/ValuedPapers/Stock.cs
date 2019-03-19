using Domain.Codes;

namespace Domain.Entities.ValuedPapers
{
	public class Stock : ValuedPaper
	{
		public override string Code { get; } = ValuedPaperCode.CommonStock.Code;
	}
}
