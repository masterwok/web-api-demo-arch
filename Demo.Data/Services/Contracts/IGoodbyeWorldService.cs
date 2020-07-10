using System.Collections.Generic;

namespace Demo.Data.Services.Contracts
{
    public interface IGoodbyeWorldService
    {
        IList<string> GetGoodbyes();
        void CreateGoodbye(string goodbye);
    }
}