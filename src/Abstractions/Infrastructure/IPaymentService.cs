using System.Threading.Tasks;

namespace Abstractions.Infrastructure
{
	public interface IPaymentService
	{
		Task<long?> MakePayment ();

		Task Check ();
	}
}
