using Microsoft.AspNetCore.TestHost;
using aurora;

namespace auroratests
{
    public static class IntegrationTestServer
    {
        public static TestServer Start() =>
            new TestServer(Program.WebHostBuilder(new string[] {}));
    }
}