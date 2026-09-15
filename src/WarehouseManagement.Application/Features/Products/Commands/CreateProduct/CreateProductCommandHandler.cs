using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.Application.Interfaces.Repositories;
using WarehouseManagement.Domain.Entities;

namespace WarehouseManagement.Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductCommandHandler: IRequestHandler<CreateProductCommand, Guid>
    {
        private readonly IProductRepository _repository;

        public CreateProductCommandHandler(IProductRepository repository) {
            _repository = repository;
        }

        public async Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product(request.SKU, request.Name, request.Description, request.Price, request.CategoryId, request.Category, request.IsActive, request.CreatedAt, request.UpdatedAt);

            await _repository.AddAsync(product);

            return product.Id;
        }
    }
}
