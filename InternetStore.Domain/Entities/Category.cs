using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore.Domain.Entities
{
    public class Category
    {
        Guid Id { get; set; }

        string? Title { get; set; }

        string? Description { get; set; }

        List<Product> Products { get; set; } = new List<Product>();


        public void Rename(string newTitle)
        {
            if (string.IsNullOrWhiteSpace(newTitle))
            {
                throw new ArgumentException("Category title cannot be empty.", nameof(newTitle));
            }
            this.Title = newTitle;
        }

        public void UpdateDescription(string? newDescription)
        {
            if (newDescription != null && newDescription.Length > 500)
            {
                throw new ArgumentException("Description cannot exceed 500 characters.", nameof(newDescription));
            }
            this.Description = newDescription;
        }
    }
}
