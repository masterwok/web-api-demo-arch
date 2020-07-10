using System.Collections.Generic;
using Demo.Data.Repositories.Contracts;

namespace Demo.Data.Repositories
{
    public class StringRepository : IStringRepository
    {
        private readonly IList<string> _strings = new List<string>();
        
        public IList<string> Read() => _strings;

        public void Create(string value) => _strings.Add(value);
    }
}