using Northwnd.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.Entity.DataTransferObject
{
    public class DtoCurrentProductList : DtoBase
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
