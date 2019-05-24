using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THS.WebAPI.Helper
{
    public class OperationResult
    {
        public string Caption { set; get; }
        public string Message { set; get; }
        public bool Success { set; get; }
        public OperationResult() { }
        public string Data { set; get; }
        public OperationResult(string caption, string message, bool success, string data)
        {
            this.Caption = caption;
            this.Message = message;
            this.Success = success;
            this.Data = data;
        }
    }
}
