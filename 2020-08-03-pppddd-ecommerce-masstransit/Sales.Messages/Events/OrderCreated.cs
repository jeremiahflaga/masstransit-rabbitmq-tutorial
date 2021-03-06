﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sales.Messages.Events
{
    public interface OrderCreated
    {
        public string OrderId { get; set; }

        public string UserId { get; set; }

        public string[] ProductIds { get; set; }

        public string ShippingTypeId { get; set; }

        public DateTime TimeStamp { get; set; }

        public double Amount { get; set; }
    }
}
