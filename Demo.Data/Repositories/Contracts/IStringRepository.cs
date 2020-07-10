using System.Collections.Generic;

namespace Demo.Data.Repositories.Contracts
{
    public interface IStringRepository
    {
        IList<string> Read();
        
        void Create(string value);
    }
}