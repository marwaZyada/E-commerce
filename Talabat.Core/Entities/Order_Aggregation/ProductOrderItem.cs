﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talabat.Core.Entities.Order_Aggregation
{
    public class ProductOrderItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public string PictureUrl { get; set; }
    }
}
