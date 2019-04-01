using System.Collections.Generic;
using Orleans;

namespace Abstractions.Grains
{
	public interface IInvoiceProcessingGrain : IGrainWithIntegerKey
	{
		long? Create (IEnumerable<long> ids);
	}
}
