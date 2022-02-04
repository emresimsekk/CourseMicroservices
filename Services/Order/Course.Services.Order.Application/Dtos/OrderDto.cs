﻿using Course.Services.Order.Domain.OrderAggregate;
using System;
using System.Collections.Generic;

namespace Course.Services.Order.Application.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get;  set; }
        public string BuyerId { get;  set; }
        public Address Address { get;  set; }

        public List<OrderItemDto> OrderItems { get; set; }
    }
}
