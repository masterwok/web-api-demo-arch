using System.Collections.Generic;
using Demo.Data.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Demo.API.Controllers
{
    [ApiController]
    [Route("Hello")]
    public class HelloWorldController : ControllerBase
    {
        private readonly IHelloWorldService _helloWorldService;

        public HelloWorldController(IHelloWorldService helloWorldService)
        {
            _helloWorldService = helloWorldService;
        }

        [HttpGet]
        [Route("Read")]
        public IList<string> GetHellos() => _helloWorldService.GetHellos();

        [HttpPost]
        [Route("Create")]
        public void Create([FromBody] string value) => _helloWorldService.CreateHello(value);
    }
}