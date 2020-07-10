using System.Collections.Generic;
using Demo.Data.Repositories.Contracts;
using Demo.Data.Services.Contracts;

namespace Demo.Data.Services
{
    public class HelloWorldService : IHelloWorldService
    {
        private readonly IStringRepository _stringRepository;

        public HelloWorldService(
            IStringRepository stringRepository
        ) => _stringRepository = stringRepository;

        public IList<string> GetHellos() => _stringRepository.Read();

        public void CreateHello(string hello) => _stringRepository.Create(hello);
    }
}