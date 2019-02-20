﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_EF.Entities
{
    public class AbstractProduct
    {
        public AbstractProduct()
        {
            RealProducts = new HashSet<RealProduct>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<RealProduct> RealProducts { get; set; }
    }
}
