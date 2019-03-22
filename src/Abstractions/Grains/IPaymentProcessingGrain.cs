using System.Collections.Generic;
using Orleans;

namespace Abstractions.Grains
{
	public interface IPaymentProcessingGrain : IGrainWithIntegerKey
	{
		IEnumerable<long> ProcessPayment(long invoiceId);
	}
}
