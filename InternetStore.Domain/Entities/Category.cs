using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore.Domain.Entities
{
    public class Category
    {
        public Category(string title, string? description = null)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("Category title cannot be empty.", nameof(title));
            }
            this.Id = Guid.NewGuid();
            this.Title = title;
            this.Description = description;
        }

        public Guid Id { get; private set; }

        public string? Title { get; private set; }

        public string? Description { get; private set; }

        public List<Product> Products { get; private set; } = new List<Product>();


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
