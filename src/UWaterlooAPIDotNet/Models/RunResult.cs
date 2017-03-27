using System;
using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models
{
    public class RunResult<T>
    {
        public bool Success { get; private set; }
        public Exception Error { get; private set; }
        public Response<T> Result { get; private set; }

        public RunResult(Response<T> data) {
            Success = true;
            Error = null;
            Result = data;
        }

        public RunResult(Exception error) {
            Success = false;
            Error = error;
            Result = null;
        }
    }
}
