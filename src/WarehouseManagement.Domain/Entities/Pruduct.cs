using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement.Domain.Entities
{
    public class Product
    {
        private Category category;

        public Guid Id { get; set; }
        public string SKU { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Product(string sKU, string name, string description, decimal price, Guid categoryId, bool isActive, DateTime createdAt, DateTime updatedAt)
        {
            SKU = sKU;
            Name = name;
            Description = description;
            Price = price;
            CategoryId = categoryId;
            IsActive = isActive;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
    }
}
