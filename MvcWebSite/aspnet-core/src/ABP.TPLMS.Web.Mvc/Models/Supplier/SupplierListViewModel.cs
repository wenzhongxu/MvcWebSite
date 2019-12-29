using ABP.TPLMS.Suppliers.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABP.TPLMS.Web.Models.Supplier
{
    public class SupplierListViewModel
    {
        public SupplierDto Supplier { get; set; }
        public IReadOnlyList<SupplierDto> Suppliers { get; set; }
    }
}
