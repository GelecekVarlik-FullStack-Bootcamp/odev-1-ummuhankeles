using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.Entity.DataTransferObject
{
    public class DtoProductsAboveAveragePrice : Dtobase
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
