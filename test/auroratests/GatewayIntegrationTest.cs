using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace auroratests
{
    [Collection("Integration")]
    public class GatewayIntegrationTest
    {
        private readonly HttpClient _testClient;
        public GatewayIntegrationTest()
        {
            _testClient = IntegrationTestServer.Start().CreateClient();
        }

        [Fact]
        public async Task ReturnGatewayConfig()
        {
            var response = await _testClient.GetAsync("/cfg");
            response.EnsureSuccessStatusCode();
            var config = await response.Content.ReadAsStringAsync();
            Console.WriteLine(config);
        }

    }
}