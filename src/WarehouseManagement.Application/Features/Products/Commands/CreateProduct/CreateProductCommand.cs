using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement.Application.Features.Products.Commands.CreateProduct
{
    public record CreateProductCommand(string Name, string Description): IRequest<Guid>;
}
