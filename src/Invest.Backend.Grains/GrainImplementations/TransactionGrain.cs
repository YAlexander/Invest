using System;
using Abstractions.Codes;
using Abstractions.Grains;
using Abstractions.Grains.StateModels;
using Invest.Backend.Grains.GrainImplementations.StateModels;
using Orleans;

namespace Invest.Backend.Grains.GrainImplementations
{
	public class TransactionGrain : Grain<TransactionState>, ITransactionGrain
	{
		public ITransactionState Get()
		{
			throw new NotImplementedException();
		}

		public string Create(ITransactionState transaction)
		{
			throw new NotImplementedException();
		}

		public bool Update(ITransactionStatusCode status)
		{
			throw new NotImplementedException();
		}
	}
}
