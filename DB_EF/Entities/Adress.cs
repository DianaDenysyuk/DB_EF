using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_EF.Entities
{
    public class Adress
    {
        public Adress()
        {
            Producers = new HashSet<Producer>();
            Orders = new HashSet<Order>();
        }
        public int Id { get; set; }
        public virtual Country Country { get; set; }
        public virtual Building Building { get; set; }
        public virtual ICollection<Producer> Producers { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
