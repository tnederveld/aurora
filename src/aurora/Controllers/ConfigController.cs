using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace aurora 
{
    [Route("/cfg")]
    public class ConfigController : Controller
    {
        private readonly IConfiguration _configuration;

        public ConfigController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IConfiguration Get() => _configuration;

    }
}