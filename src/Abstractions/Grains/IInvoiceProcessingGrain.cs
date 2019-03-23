using System.Collections.Generic;
using Orleans;

namespace Abstractions.Grains
{
	public interface IInvoiceProcessingGrain : IGrainWithIntegerKey
	{
		long? InvoiceShares(IEnumerable<long> ids);
	}
}
