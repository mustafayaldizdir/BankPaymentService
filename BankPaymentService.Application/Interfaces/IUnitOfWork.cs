using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPaymentService.Application.Interfaces
{
    public interface IUnitOfWork
    {
        public ICcBinCodeRepository CcBinCodes  {get;}
        public IPaymentInfoRepository PaymentInfos { get; }
        Task CommitAsync();
        void Commit();
    }
}
