using FluentValidation;
using Invest.Site.Core.Models;

namespace Invest.Site.Core.Validators
{
	public class InvestmentInfoValidator : AbstractValidator<InvestedInfoDTO>
	{
		public InvestmentInfoValidator()
		{
			RuleFor(x => x.NumberOfShares).GreaterThan(0);
		}
	}
}
