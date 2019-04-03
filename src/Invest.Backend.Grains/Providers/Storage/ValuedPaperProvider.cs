using System;
using System.Threading.Tasks;
using Abstractions.Infrastructure.Database;
using Domain.Codes;
using Domain.Entities.ValuedPapers;
using Invest.Backend.Grains.GrainImplementations.StateModels;
using Invest.Backend.Grains.Helpers;
using Invest.Backend.Infrastructure.Database;
using Orleans;
using Orleans.Providers;
using Orleans.Runtime;
using Orleans.Storage;

namespace Invest.Backend.Grains.Providers.Storage
{
	public class ValuedPaperProvider : IStorageProvider
	{
		private IUnitOfWork _unitOfWork;
		private readonly IValuedPapersManager<Bill> _billValuedPapersManager;
		private readonly IValuedPapersManager<Stock> _stockValuedPapersManager;
		private readonly IValuedPapersManager<ConvertibleBond> _convertibleBondValuedPapersManager;
		private readonly IValuedPapersManager<CorporateBond> _corporateBondValuedPapersManager;
		private readonly IValuedPapersManager<Coupon> _couponValuedPapersManager;
		private readonly IValuedPapersManager<Voucher> _voucherValuedPapersManager;
		private readonly IValuedPapersManager<Share> _shareValuedPapersManager;


		public ValuedPaperProvider (
			IUnitOfWork unitOfWork,
			IValuedPapersManager<Bill> billValuedPapersManager,
			IValuedPapersManager<Stock> stockValuedPapersManager,
			IValuedPapersManager<ConvertibleBond> convertibleBondValuedPapersManager,
			IValuedPapersManager<CorporateBond> corporateBondValuedPapersManager,
			IValuedPapersManager<Coupon> couponValuedPapersManager,
			IValuedPapersManager<Voucher> voucherValuedPapersManager,
			IValuedPapersManager<Share> shareValuedPapersManager)
		{
			_unitOfWork = unitOfWork;
			_billValuedPapersManager = billValuedPapersManager;
			_stockValuedPapersManager = stockValuedPapersManager;
			_convertibleBondValuedPapersManager = convertibleBondValuedPapersManager;
			_corporateBondValuedPapersManager = corporateBondValuedPapersManager;
			_couponValuedPapersManager = couponValuedPapersManager;
			_voucherValuedPapersManager = voucherValuedPapersManager;
			_shareValuedPapersManager = shareValuedPapersManager;
		}

		public async Task ReadStateAsync(string grainType, GrainReference grainReference, IGrainState grainState)
		{
			long key = grainReference.GetPrimaryKeyLong(out string keyExtension);

			using (var unitOfWork = new UnitOfWork())
			{
				ValuedPaperCode code = ValuedPaperCode.Create(keyExtension);

				if (code == ValuedPaperCode.Bill)
				{
					Bill bill = await _billValuedPapersManager.Get(key, unitOfWork.Connection, unitOfWork.Transaction);
					grainState.State = bill.Map();
				}
				else if (code == ValuedPaperCode.CommonStock)
				{
					Stock stock = await _stockValuedPapersManager.Get(key, unitOfWork.Connection, unitOfWork.Transaction);
					grainState.State = stock.Map();
				}
				else if (code == ValuedPaperCode.ConvertibleBond)
				{
					ConvertibleBond bond = await _convertibleBondValuedPapersManager.Get(key, unitOfWork.Connection, unitOfWork.Transaction);
					grainState.State = bond.Map();
				}
				else if (code == ValuedPaperCode.CorporateBond)
				{
					CorporateBond bond = await _corporateBondValuedPapersManager.Get(key, unitOfWork.Connection, unitOfWork.Transaction);
					grainState.State = bond.Map();
				}
				else if (code == ValuedPaperCode.Share)
				{
					Share share = await _shareValuedPapersManager.Get(key, unitOfWork.Connection, unitOfWork.Transaction);
					grainState.State = share.Map();
				}
				else if (code == ValuedPaperCode.Voucher)
				{
					Voucher voucher = await _voucherValuedPapersManager.Get(key, unitOfWork.Connection, unitOfWork.Transaction);
					grainState.State = voucher.Map();
				}
				else
				{
					throw new Exception("Unknown type code");
				}
			}
		}

		public Task WriteStateAsync(string grainType, GrainReference grainReference, IGrainState grainState)
		{
			throw new NotImplementedException();
		}

		public Task ClearStateAsync(string grainType, GrainReference grainReference, IGrainState grainState)
		{
			return Task.CompletedTask;
		}

		public Task Init(string name, IProviderRuntime providerRuntime, IProviderConfiguration config)
		{
			Name = name;
			return Task.CompletedTask;
		}

		public Task Close()
		{
			return Task.CompletedTask;
		}

		public string Name { get; set; } = string.Empty;
	}
}
