﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_EF.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
        public Adress DeliveryAdress { get; set; }
        public RealProduct RealProduct { get; set; }
        public User User { get; set; }
    }
}