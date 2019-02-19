using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_EF.Entities
{
    public class Building
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Latter { get; set; }
        public virtual ICollection<Adress> Adresses { get; set; }
    }
}
