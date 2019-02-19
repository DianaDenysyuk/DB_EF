using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_EF.Entities
{
    public class Adress
    {
        public int Id { get; set; }
        public Country Country { get; set; }
        public Building Building { get; set; }
        public virtual ICollection<Producer> Producers { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
