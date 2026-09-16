namespace WarehouseManagement.Web.Models
{
	public class Category
	{
		public Guid Id { get; set; }
		public string? Name { get; set; }
		public string? Description { get; set; }
		public ICollection<Product>? Products { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }

		public Category()
		{
			Products = new List<Product>();
		}
	}
}
