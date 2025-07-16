using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternetStore.Domain.Enums;

namespace InternetStore.Application.DTOs
{
    internal class OrderDto
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public CustomerDto? Customer { get; set; }
        public OrderStatus Status { get; set; }
        public decimal TotalAmount { get; set; }
        public List<OrderItemDto> Items { get; set; } = new List<OrderItemDto>();
    }
}
