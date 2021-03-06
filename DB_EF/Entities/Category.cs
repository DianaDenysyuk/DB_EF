﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_EF.Entities
{
    public class Category
    {
        public Category()
        {
            AbstractProducts = new HashSet<AbstractProduct>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsLegal { get; set; }
        public virtual ICollection<AbstractProduct> AbstractProducts { get; set; }
    }
}
