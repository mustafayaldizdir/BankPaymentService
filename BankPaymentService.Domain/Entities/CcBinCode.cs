using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPaymentService.Domain.Entities
{
    public class CcBinCode
    {
        public int Id { get; set; }
        public int BinCode { get; set; }
        public short BankCode { get; set; }
        public string BankName { get; set; }
        public string CardType { get; set; }
        public string Organization { get; set; }
        public bool IsCommercialCard { get; set; }
        public bool IsSupportInstallment { get; set; }
        public bool IsActive { get; set; }

    }
}
