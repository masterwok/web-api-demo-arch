using System.Collections.Generic;
using Demo.Data.Repositories.Contracts;
using Demo.Data.Services.Contracts;

namespace Demo.Data.Services
{
    public class GoodbyeWorldService : IGoodbyeWorldService
    {
        private readonly IStringRepository _stringRepository;

        public GoodbyeWorldService(
            IStringRepository stringRepository
        ) => _stringRepository = stringRepository;

        public IList<string> GetGoodbyes() => _stringRepository.Read();

        public void CreateGoodbye(string goodbye) => _stringRepository.Create(goodbye);
    }
}