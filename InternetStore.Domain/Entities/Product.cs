using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore.Domain.Entities
{
    public class Product
    {
        public Product(string title)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(title);
            this.Id = Guid.NewGuid();
            this.Title = title;
            this.CreatedAt = DateTime.UtcNow;
            this.ShortDescriptions = string.Empty;
            this.Available = false;

        }

        public Guid Id { get; set; }

        public string Title { get; set; }

        public string ShortDescriptions { get; set; }

        public DateTime CreatedAt { get; set; }

        public decimal Price { get; set; } = 0;

        public bool  Available { get; set; } = false;
    }
}
