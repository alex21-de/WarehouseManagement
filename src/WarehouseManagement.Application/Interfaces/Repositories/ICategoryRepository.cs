using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.Domain.Entities;

namespace WarehouseManagement.Application.Interfaces.Repositories
{
	public interface ICategoryRepository
	{
		Task AddAsync(Category category);
		Task<Category?> GetByIdAsync(Guid id);
	}
}
