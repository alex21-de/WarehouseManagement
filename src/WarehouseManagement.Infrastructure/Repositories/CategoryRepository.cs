using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.Application.Interfaces.Repositories;
using WarehouseManagement.Domain.Entities;

namespace WarehouseManagement.Infrastructure.Repositories
{
	public class CategoryRepository : ICategoryRepository
	{
		private readonly AppDbContext _appDbContext;

		public CategoryRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}

		public async Task AddAsync(Category category)
		{
			_appDbContext.Categories.Add(category);

			await _appDbContext.SaveChangesAsync();
		}

		public Task<Category?> GetByIdAsync(Guid id)
		{
			throw new NotImplementedException();
		}
	}
}
