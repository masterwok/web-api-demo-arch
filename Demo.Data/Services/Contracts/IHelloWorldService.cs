using System.Collections.Generic;

namespace Demo.Data.Services.Contracts
{
    public interface IHelloWorldService
    {
        IList<string> GetHellos();
        void CreateHello(string hello);
    }
}