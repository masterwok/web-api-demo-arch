using System.Collections.Generic;
using Demo.Data.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Demo.API.Controllers
{
    [ApiController]
    [Route("Goodbye")]
    public class GoodbyeWorldController : ControllerBase
    {
        private readonly IGoodbyeWorldService _goodbyeWorldService;

        public GoodbyeWorldController(
            IGoodbyeWorldService goodbyeWorldService
        ) => _goodbyeWorldService = goodbyeWorldService;

        [HttpGet]
        [Route("Read")]
        public IList<string> GetHellos() => _goodbyeWorldService.GetGoodbyes();

        [HttpPost]
        [Route("Create")]
        public void Create([FromBody] string value) => _goodbyeWorldService.CreateGoodbye(value);
    }
}