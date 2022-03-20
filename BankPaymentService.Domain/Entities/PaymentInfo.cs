using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPaymentService.Domain.Entities
{
    public class PaymentInfo
    {
        public int Id { get; set; }
        public int BankId { get; set; }
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public int Cvv { get; set; }
        public string ExpirationDate { get; set; }
        public DateTime CreatedDate { get; set; }

        public Bank Bank { get; set; }
    }
}
