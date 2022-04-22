using Northwnd.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.Entity.DataTransferObject
{
    public class DtoCustomerDemographic : DtoBase
    {
        public DtoCustomerDemographic()
        {
        }

        public string CustomerTypeId { get; set; }
        public string CustomerDesc { get; set; }
    }
}
