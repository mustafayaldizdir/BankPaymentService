using BankPaymentService.Application.Dto;
using BankPaymentService.Application.Dto.PaymentInfo;
using BankPaymentService.Application.Interfaces;
using BankPaymentService.Application.Interfaces.Repositories;
using BankPaymentService.Domain.Entities;
using BankPaymentService.Infrastructure.Enum;
using BankPaymentService.Persistence.Services.BankServices;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPaymentService.Persistence.Factory
{
    public class BankFactory : IBankFactory
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ICcBinCodeRepository _ccBinCodeRepository;
        private readonly IBankRepository _bankRepository;

        public BankFactory(
            ICcBinCodeRepository ccBinCodeRepository,
            IBankRepository bankRepository,
            IServiceProvider serviceProvider)
        {
            _ccBinCodeRepository = ccBinCodeRepository;
            _bankRepository = bankRepository;
            _serviceProvider = serviceProvider;
        }

        public IPaymentProvider Create(PaymentInfoDto paymentInfoDto)
        {
            var ccBinCode = _ccBinCodeRepository.GetBankData(paymentInfoDto.CardNumber.Substring(0, 6)).Result;
            var bank = _bankRepository.GetAsync(x => x.BankCode == ccBinCode.BankCode).Result;
            paymentInfoDto.BankId = bank.Id;
            paymentInfoDto.CreatedDate = DateTime.UtcNow;
            switch ((BankName)bank.BankCode)
            {
                case BankName.ZiraatBankService:
                    return ActivatorUtilities.GetServiceOrCreateInstance<ZiraatBankService>(_serviceProvider);
                case BankName.HalkBankService:
                    return ActivatorUtilities.GetServiceOrCreateInstance<HalkBankService>(_serviceProvider);
                case BankName.VakifBankService:
                    return ActivatorUtilities.GetServiceOrCreateInstance<VakifBankService>(_serviceProvider);
                case BankName.TurkEkonomiBankService:
                    return ActivatorUtilities.GetServiceOrCreateInstance<TurkEkonomiBankService>(_serviceProvider);
                case BankName.AkbankService:
                    return ActivatorUtilities.GetServiceOrCreateInstance<AkbankService>(_serviceProvider);
                case BankName.SekerBankService:
                    return ActivatorUtilities.GetServiceOrCreateInstance<SekerBankService>(_serviceProvider);
                case BankName.GarantiBankService: 
                    return ActivatorUtilities.GetServiceOrCreateInstance<GarantiBankService>(_serviceProvider);
                case BankName.IsBankService: 
                    return ActivatorUtilities.GetServiceOrCreateInstance<IsBankService>(_serviceProvider);
                case BankName.YapiKrediBankService: 
                    return ActivatorUtilities.GetServiceOrCreateInstance<YapiKrediBankService>(_serviceProvider);
                case BankName.CitiBankService: 
                    return ActivatorUtilities.GetServiceOrCreateInstance<CitiBankService>(_serviceProvider);
                case BankName.TurkishBankService: 
                    return ActivatorUtilities.GetServiceOrCreateInstance<TurkishBankService>(_serviceProvider);
                case BankName.IngBankService: 
                    return ActivatorUtilities.GetServiceOrCreateInstance<IngBankService>(_serviceProvider);
                case BankName.FibaBankService: 
                    return ActivatorUtilities.GetServiceOrCreateInstance<FibaBankService>(_serviceProvider);
                case BankName.TurklandBankService: 
                    return ActivatorUtilities.GetServiceOrCreateInstance<TurklandBankService>(_serviceProvider);
                case BankName.IcbcTurkeyBankService:
                    return ActivatorUtilities.GetServiceOrCreateInstance<IcbcTurkeyBankService>(_serviceProvider);
                case BankName.QnbFinansBankService: 
                    return ActivatorUtilities.GetServiceOrCreateInstance<QnbFinansBankService>(_serviceProvider);
                case BankName.HsbcBankService: 
                    return ActivatorUtilities.GetServiceOrCreateInstance<HsbcBankService>(_serviceProvider);
                case BankName.AlternatifBankService: 
                    return ActivatorUtilities.GetServiceOrCreateInstance<AlternatifBankService>(_serviceProvider);
                case BankName.BurganBankService: 
                    return ActivatorUtilities.GetServiceOrCreateInstance<BurganBankService>(_serviceProvider);
                case BankName.DenizBankService: 
                    return ActivatorUtilities.GetServiceOrCreateInstance<DenizBankService>(_serviceProvider);
                case BankName.AnadoluBankService: 
                    return ActivatorUtilities.GetServiceOrCreateInstance<AnadoluBankService>(_serviceProvider);
                case BankName.AktifYatirimBankService: 
                    return ActivatorUtilities.GetServiceOrCreateInstance<AktifYatirimBankService>(_serviceProvider);
                case BankName.OdeaBankService: 
                    return ActivatorUtilities.GetServiceOrCreateInstance<OdeaBankService>(_serviceProvider);
                case BankName.GoldenGlobalYatirimBankService: 
                    return ActivatorUtilities.GetServiceOrCreateInstance<GoldenGlobalYatirimBankService>(_serviceProvider);
                case BankName.AlbarakaTurkKatilimBankService: 
                    return ActivatorUtilities.GetServiceOrCreateInstance<AlbarakaTurkKatilimBankService>(_serviceProvider);
                case BankName.KuveytTurkKatilimBankService: 
                    return ActivatorUtilities.GetServiceOrCreateInstance<KuveytTurkKatilimBankService>(_serviceProvider);
                case BankName.FinansKatilimBankService: 
                    return ActivatorUtilities.GetServiceOrCreateInstance<FinansKatilimBankService>(_serviceProvider);
                case BankName.ZiraatKatilimBankService: 
                    return ActivatorUtilities.GetServiceOrCreateInstance<ZiraatKatilimBankService>(_serviceProvider);
                case BankName.VakifKatilimBankService: 
                    return ActivatorUtilities.GetServiceOrCreateInstance<VakifKatilimBankService>(_serviceProvider);
                case BankName.TurkiyeEmlakKatilimBankService: 
                    return ActivatorUtilities.GetServiceOrCreateInstance<TurkiyeEmlakKatilimBankService>(_serviceProvider);
                case BankName.OzanElektronikParaBankService: 
                    return ActivatorUtilities.GetServiceOrCreateInstance<OzanElektronikParaBankService>(_serviceProvider);
                case BankName.IyziOdemeVeElektronikParaBankService: 
                    return ActivatorUtilities.GetServiceOrCreateInstance<IyziOdemeVeElektronikParaBankService>(_serviceProvider);
                case BankName.TtOdemeVeElektronikParaBankService: 
                    return ActivatorUtilities.GetServiceOrCreateInstance<TtOdemeVeElektronikParaBankService>(_serviceProvider);
                case BankName.LydiansElektronikParaBankService: 
                    return ActivatorUtilities.GetServiceOrCreateInstance<LydiansElektronikParaBankService>(_serviceProvider);
                case BankName.PaycoreBankService: 
                    return ActivatorUtilities.GetServiceOrCreateInstance<PaycoreBankService>(_serviceProvider);
                case BankName.TurkElektronikParaBankService: 
                    return ActivatorUtilities.GetServiceOrCreateInstance<TurkElektronikParaBankService>(_serviceProvider);
                case BankName.PaparaElektronikParaBankService: 
                    return ActivatorUtilities.GetServiceOrCreateInstance<PaparaElektronikParaBankService>(_serviceProvider);
                case BankName.PostaVeTelgrafTeskilatiBankService: 
                    return ActivatorUtilities.GetServiceOrCreateInstance<PostaVeTelgrafTeskilatiBankService>(_serviceProvider);
                case BankName.IninalBankService: 
                    return ActivatorUtilities.GetServiceOrCreateInstance<IninalBankService>(_serviceProvider);
                case BankName.TurkcellBankService: 
                    return ActivatorUtilities.GetServiceOrCreateInstance<TurkcellBankService>(_serviceProvider);
                case BankName.PaladyumBankService: 
                    return ActivatorUtilities.GetServiceOrCreateInstance<PaladyumBankService>(_serviceProvider);
                default:
                    return null;


            }
        }
    }
}
