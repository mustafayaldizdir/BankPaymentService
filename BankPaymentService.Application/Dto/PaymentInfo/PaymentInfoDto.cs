using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPaymentService.Application.Dto.PaymentInfo
{
    public class PaymentInfoDto
    {
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public int Cvv { get; set; }
        public string ExpirationDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
