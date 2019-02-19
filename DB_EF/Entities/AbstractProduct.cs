﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_EF.Entities
{
    public class AbstractProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public virtual ICollection<RealProduct> RealProducts { get; set; }
    }
}
