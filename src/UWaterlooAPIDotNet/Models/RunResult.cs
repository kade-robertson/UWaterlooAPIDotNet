using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UWaterlooAPIDotNet.Models
{
    public class RunResult<T>
    {
        public bool Success { get; private set; }
        public Exception Error { get; private set; }
        public Response<T> Data { get; private set; }

        public RunResult(string data) {
            Success = true;
            Error = null;
            Data = JsonConvert.DeserializeObject<Response<T>>(data);
        }

        public RunResult(Exception error) {
            Success = false;
            Error = error;
            Data = null;
        }
    }
}
