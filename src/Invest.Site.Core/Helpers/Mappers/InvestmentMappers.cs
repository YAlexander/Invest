using System;
using System.Collections.Generic;
using System.Text;
using Abstractions.Grains.StateModels;
using Invest.Site.Core.Models;

namespace Invest.Site.Core.Helpers.Mappers
{
	public static class InvestmentMappers
	{
		public static InvestmentDTO ToModel(this IInvestmentState entity)
		{
			InvestmentDTO model = new InvestmentDTO();

			return model;
		}
	}
}
