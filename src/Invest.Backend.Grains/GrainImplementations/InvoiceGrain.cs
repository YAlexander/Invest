using System.Threading.Tasks;
using Abstractions.Grains;
using Abstractions.Grains.StateModels;
using Invest.Backend.Grains.GrainImplementations.StateModels;
using Orleans;

namespace Invest.Backend.Grains.GrainImplementations
{
	public class InvoiceGrain : Grain<InvoiceState>, IInvoiceGrain
	{
		public IInvoiceState Get()
		{
			throw new System.NotImplementedException();
		}

		public async Task<IInvoiceState> Update(IInvoiceState invoice)
		{
			this.State = (InvoiceState)invoice;
			await this.WriteStateAsync();
			return this.State;
		}
	}
}
