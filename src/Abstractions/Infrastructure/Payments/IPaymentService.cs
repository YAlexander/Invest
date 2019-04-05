using System.Threading.Tasks;

namespace Abstractions.Infrastructure.Payments
{
	public interface IPaymentService
	{
		Task<long?> MakePayment ();

		Task Check ();
	}
}
