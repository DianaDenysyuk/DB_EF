using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_EF.Entities
{
    public class RealProduct
    {
        public RealProduct()
        {
            Orders = new HashSet<Order>();
        }
        public int Id { get; set; }
        public int Price { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpiresDate { get; set; }
        public int Quantity { get; set; }
        public virtual Producer Producer { get; set; }
        public virtual AbstractProduct AbsProduct { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
