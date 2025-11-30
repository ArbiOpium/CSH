using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_all.Data.Dto
{
    using csharp_all.Data.Attributes;

    [TableName("ShopSales")]
    internal class Sale
    {
        public Guid Id { get; set; }
        public Guid ManagerId { get; set; }
        public Guid ProductId { get; set; }
        public DateTime Moment { get; set; }
        public int Quantity { get; set; }
    }
}
