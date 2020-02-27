using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SQL.Models
{
    public class ErrorModel
    {
        public ErrorModel(string exceptionMsg, string stackTrace)
        {
            errorMsg = exceptionMsg;
            errorStackTrace = stackTrace;
        }
        public string errorMsg { get; set; }
        public string errorStackTrace { get; set; }
    }
}
