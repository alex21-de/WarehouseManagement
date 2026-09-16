using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement.Domain.Entities
{
	public class Category
	{
		public Guid Id { get; set; }
		public string? Name { get; set; }
		public string? Description { get; set; }
		public ICollection<Product> Products { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }

		//Create
		public Category(string? name, string? description)
		{
			Name = name;
			Description = description;
			CreatedAt = DateTime.Now;
			UpdatedAt = DateTime.Now;
		}
	}
}
