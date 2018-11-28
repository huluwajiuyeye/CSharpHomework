﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace project1
{
    public class OrderDB:DbContext
    {
        public OrderDB() :base("OrderDataBase")
        {
        }
        public DbSet<OrderDetail> Order { get; set; }
        
    }
}
