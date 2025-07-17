using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore.Application.DTOs
{
    public class CreateOrderRequestDto
    {
        public Guid CustomerId { get; set; }

        public List<OrderItemInputDto> OrderItems { get; set; }


    }
}
