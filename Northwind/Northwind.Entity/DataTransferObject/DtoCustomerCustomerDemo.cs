using Northwnd.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.Entity.DataTransferObject
{
    public class DtoCustomerCustomerDemo : DtoBase
    {
        public string CustomerId { get; set; }
        public string CustomerTypeId { get; set; }
    }
}
