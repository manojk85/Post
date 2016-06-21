using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wPostLayer.APIServices
{
    public interface IAPIAsyncCaller
    {
        Uri BaseAPIUri { get; set; }
        String Accept { get; set; }
  
    }
}
