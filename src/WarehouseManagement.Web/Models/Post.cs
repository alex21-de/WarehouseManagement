using Microsoft.AspNetCore.Http.HttpResults;

namespace WarehouseManagement.Web.Models
{
	public class Post
	{
		public Guid Id { get; set; }
		public string? Title { get; set; }
		public string? Description { get; set; }
		public string? Author { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime UpdatedDate { get; set; }
		public Post()
		{
			CreatedDate = DateTime.Now;
			UpdatedDate = DateTime.Now;
		}

	}
}
