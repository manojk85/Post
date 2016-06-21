using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wPostLayer.APIServices
{
    public interface IAsyncPostAPICaller : IAPIAsyncCaller
    {
        Task<string> Get(string url);

    }
}
