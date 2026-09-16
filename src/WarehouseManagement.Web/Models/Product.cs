using System;

namespace WarehouseManagement.Web.Models
{
	public class Product
	{
		public Guid Id { get; set; }
		public string? SKU { get; set; }
		public string? Name { get; set; }
		public string? Description { get; set; }
		public decimal Price { get; set; }
		public Guid CategoryId { get; set; }
		public Category? Category { get; set; }
		public bool IsActive { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }

		public Product()
		{
			Category = new Category();
			CreatedAt = DateTime.Now;
			UpdatedAt = DateTime.Now;
		}

	}
}
