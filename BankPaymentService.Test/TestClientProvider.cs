using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BankPaymentService.Test
{
     class TestClientProvider
    {
        public HttpClient Client;

        public TestClientProvider()
        {
            var server = new TestServer(new WebHostBuilder().UseKestrel());

            Client = server.CreateClient();
        }
    }
}
