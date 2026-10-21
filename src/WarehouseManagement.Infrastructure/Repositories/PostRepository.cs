using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.Application.Interfaces.Repositories;
using WarehouseManagement.Domain.Entities;

namespace WarehouseManagement.Infrastructure.Repositories
{
	public class PostRepository : IPostRepository
	{
		private readonly AppDbContext _appDbContext;

		public PostRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}

		public async Task AddAsync(Post post)
		{
			_appDbContext.Posts.Add(post);

			await _appDbContext.SaveChangesAsync();
		}

		public Task<Post?> GetByIdAsync(Guid id)
		{
			throw new NotImplementedException();
		}
	}
}
