using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core
{
    public class ServiceResult
    {
        public ServiceResult(string message, ResultState state)
        {
            Message = message;
            State = state;
        }
        public string Message { get; set; }
        public ResultState State { get; set; }
    }
}
