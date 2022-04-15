using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPaymentService.Application.Interfaces.Services
{
    public interface IRedisService
    {
         void Connect();

        IDatabase GetDb(int db);

    }
}
