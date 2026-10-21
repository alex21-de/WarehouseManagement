using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement.Domain.Entities
{
	public class Post
	{
		public Guid Id { get; set; }
		public string? Title { get; set; }
		public string? Description { get; set; }
		public string? Author { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime UpdatedDate { get; set; }

		public Post(string title, string description, string author, DateTime createdDate, DateTime updatedDate) {
			Title = title;
			Description	= description;
			Author = author;
			CreatedDate = createdDate;
			UpdatedDate = updatedDate;
		}
	}
}
