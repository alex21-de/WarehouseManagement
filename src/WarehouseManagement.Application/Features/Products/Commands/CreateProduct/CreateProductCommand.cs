using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.Domain.Entities;

namespace WarehouseManagement.Application.Features.Products.Commands.CreateProduct
{
    public record CreateProductCommand(string SKU, string Name, string Description, decimal Price, 
        Guid CategoryId, bool IsActive, DateTime CreatedAt, DateTime UpdatedAt) : IRequest<Guid>;
}
