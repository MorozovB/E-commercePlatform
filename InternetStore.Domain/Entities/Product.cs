using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore.Domain.Entities
{
    public class Product
    {
        public Product(string title, decimal price, Guid categoryId)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(title);

            if (price < 0)
            {
                throw new ArgumentException("Price cannot be negative.", nameof(price));
            }
            if (categoryId == Guid.Empty)
            {
                throw new ArgumentException("Category ID cannot be empty.", nameof(categoryId));
            }
            this.Id = Guid.NewGuid();
            this.Title = title;
            this.CreatedAt = DateTime.UtcNow;
            this.ShortDescriptions = string.Empty;
            this.Available = false;
            this.Price = price;
            this.CategoryId = categoryId;
        }

        public Guid Id { get; private set; }

        public string Title { get; private set; }

        public string ShortDescriptions { get; private set; }

        public DateTime CreatedAt { get; private set; }

        public decimal Price { get; private set; } = 0;

        public bool  Available { get; private set; } = false;

        public int Quantity { get; private set; } = 0;

        public Category? Category { get; private set; }

        public Guid CategoryId { get; private set; }

        public double Rating { get; private set; } = 0;

        public void ChangePrice(decimal newPrice)
        {
            if (newPrice < 0)
            {
                throw new ArgumentException("Price cannot be negative.", nameof(newPrice));
            }
            this.Price = newPrice;
        }

        public void ChangeTitle(string newTitle)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(newTitle);
            if (string.IsNullOrWhiteSpace(newTitle))
            {
                throw new ArgumentException("Product title cannot be empty.", nameof(newTitle));
            }
            this.Title = newTitle;
        }

        public void UpdateShortDescription(string? newDescription)
        {
            if (newDescription != null && newDescription.Length > 500)
            {
                throw new ArgumentException("Description cannot exceed 500 characters.", nameof(newDescription));
            }
            this.ShortDescriptions = newDescription ?? string.Empty;
        }

        public void SetAvailability(bool isAvailable)
        {
            this.Available = isAvailable;
        }

        public void GhangeQuantity(int newQuantity)
        {
            if (newQuantity < 0)
            {
                throw new ArgumentException("Quantity cannot be negative.", nameof(newQuantity));
            }
            this.Quantity = newQuantity;
        }

        public void SetRaiting(double newRating)
        {
            if (newRating < 0 || newRating > 5)
            {
                throw new ArgumentOutOfRangeException(nameof(newRating), "Rating must be between 0 and 5.");
            }
            this.Rating = newRating;
        }
    }
}
