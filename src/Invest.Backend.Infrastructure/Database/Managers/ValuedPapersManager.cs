using System;
using Abstractions.Entities;
using Abstractions.Infrastructure;

namespace Invest.Backend.Infrastructure.Database.Managers
{
	public class ValuedPapersManager<T> : IValuedPapersManager<T> where T : IValuedPaper
	{
		public int GetType (long id)
		{
			throw new NotImplementedException();
		}
	}
}
