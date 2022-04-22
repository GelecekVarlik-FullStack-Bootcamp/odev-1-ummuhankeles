using Northwnd.Entity.IBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.Entity.Base
{
    public class Response : IResponse
    {
        public string Messsage { get; set; }
        public int StatusCode { get; set; }
        public object Data { get; set; }
    }

    public class Response<T> : IResponse<T>
    {
        public string Messsage { get; set; }
        public int StatusCode { get; set; }
        public T Data { get; set; }
    }

}
