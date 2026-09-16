using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WarehouseManagement.Application.Interfaces.Repositories;

namespace WarehouseManagement.Application.Features.Category.Commands.CreateCategory
{
	public class CreateCategoryCommandHandler
	{
		private readonly ICategoryRepository _repository;

		public CreateCategoryCommandHandler(ICategoryRepository repository)
		{
			_repository = repository;
		}

		public async Task<Guid> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
		{
			var category = new Domain.Entities.Category(request.Name, request.Description);

			await _repository.AddAsync(category);

			return category.Id;
		}
	}
}
