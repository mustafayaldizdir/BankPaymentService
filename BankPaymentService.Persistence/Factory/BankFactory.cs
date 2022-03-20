using BankPaymentService.Application.Dto;
using BankPaymentService.Application.Dto.PaymentInfo;
using BankPaymentService.Application.Interfaces;
using BankPaymentService.Application.Interfaces.Banks;
using BankPaymentService.Application.Interfaces.Repositories;
using BankPaymentService.Domain.Entities;
using BankPaymentService.Infrastructure.Enum;
using BankPaymentService.Persistence.Services.BankServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPaymentService.Persistence.Factory
{
    public class BankFactory : IBankFactory
    {
        private readonly ICcBinCodeRepository _ccBinCodeRepository;
        private readonly IBankRepository _bankRepository;
        private readonly IAkbankService _akbankService;

        public BankFactory(
            ICcBinCodeRepository ccBinCodeRepository,
            IBankRepository bankRepository, IAkbankService akbankService)
        {
            _ccBinCodeRepository = ccBinCodeRepository;
            _bankRepository = bankRepository;
            _akbankService = akbankService;
        }



        public async Task<Response<PaymentInfo>> Payment(PaymentInfoDto paymentInfoDto)
        {

            var ccBinCode =  _ccBinCodeRepository.GetBankData(paymentInfoDto.CardNumber.Substring(0,5)).Result;
            var bank =  _bankRepository.GetAsync(x => x.BankCode == ccBinCode.BankCode).Result;


            var response = new Response<PaymentInfo>();
            switch (bank.BankCode)
            {
                case (int)BankName.ZiraatBankService:
                    break;
                case (int)BankName.HalkBankService:
                    break;
                case (int)BankName.VakifBankService:
                    break;
                case (int)BankName.TurkEkonomiBankService:
                    break;
                case (int)BankName.AkbankService:
                   response = await _akbankService.BankPayment(paymentInfoDto);
                    break;
                case (int)BankName.SekerBankService:
                    break;
                case (int)BankName.GarantiBankService:
                    break;
                case (int)BankName.IsBankService:
                    break;
                case (int)BankName.YapiKrediBankService:
                    break;
                case (int)BankName.CitiBankService:
                    break;
                case (int)BankName.TurkishBankService:
                    break;
                case (int)BankName.IngBankService:
                    break;
                case (int)BankName.FibaBankService:
                    break;
                case (int)BankName.TurklandBankService:
                    break;
                case (int)BankName.IcbcTurkeyBankService:
                    break;
                case (int)BankName.QnbFinansBankService:
                    break;
                case (int)BankName.HsbcBankService:
                    break;
                case (int)BankName.AlternatifBankService:
                    break;
                case (int)BankName.BurganBankService:
                    break;
                case (int)BankName.DenizBankService:
                    break;
                case (int)BankName.AnadoluBankService:
                    break;
                case (int)BankName.AktifYatirimBankService:
                    break;
                case (int)BankName.OdeaBankService:
                    break;
                case (int)BankName.GoldenGlobalYatirimBankService:
                    break;
                case (int)BankName.AlbarakaTurkKatilimBankService:
                    break;
                case (int)BankName.KuveytTurkKatilimBankService:
                    break;
                case (int)BankName.FinansKatilimBankService:
                    break;
                case (int)BankName.ZiraatKatilimBankService:
                    break;
                case (int)BankName.VakifKatilimBankService:
                    break;
                case (int)BankName.TurkiyeEmlakKatilimBankService:
                    break;
                case (int)BankName.OzanElektronikParaBankService:
                    break;
                case (int)BankName.IyziOdemeVeElektronikParaBankService:
                    break;
                case (int)BankName.TtOdemeVeElektronikParaBankService:
                    break;
                case (int)BankName.LydiansElektronikParaBankService:
                    break;
                case (int)BankName.PaycoreBankService:
                    break;
                case (int)BankName.TurkElektronikParaBankService:
                    break;
                case (int)BankName.PaparaElektronikParaBankService:
                    break;
                case (int)BankName.PostaVeTelgrafTeskilatiBankService:
                    break;
                case (int)BankName.IninalBankService:
                    break;
                case (int)BankName.TurkcellBankService:
                    break;
                case (int)BankName.PaladyumBankService:
                    break;
                default:
                    break;

            }

            return paymentProvider;
        }
    }
}
