﻿using Shop.Date.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Date.Interface
{
   public interface IAllOrders
    {
        void createOrder(Order order);
    }
}
