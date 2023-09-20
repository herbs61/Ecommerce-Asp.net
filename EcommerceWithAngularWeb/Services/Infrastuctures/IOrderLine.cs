﻿using EcommerceWithAngularWeb.Models;

namespace EcommerceWithAngularWeb.Services.Infrastuctures
{
    public interface IOrderLine
    {
        IEnumerable<OrderLine> GetOrderLines();
        OrderLine GetOrderLine(int id);
        void Insert(OrderLine orderLine);
        void Update(OrderLine orderLine);
        int Count();
        void Save();
    }
}
