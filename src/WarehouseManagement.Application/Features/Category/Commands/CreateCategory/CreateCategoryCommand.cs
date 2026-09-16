using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.Domain.Entities;

namespace WarehouseManagement.Application.Features.Category.Commands.CreateCategory
{
	public record CreateCategoryCommand(string? Name, string? Description) : IRequest<Guid>;
}