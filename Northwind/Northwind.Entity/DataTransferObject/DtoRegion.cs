using Northwnd.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.Entity.DataTransferObject
{
    public class DtoRegion : DtoBase
    {
        public DtoRegion()
        {
        }

        public int RegionId { get; set; }
        public string RegionDescription { get; set; }
    }
}
