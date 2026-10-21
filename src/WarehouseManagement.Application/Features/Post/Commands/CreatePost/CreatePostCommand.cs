using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.Domain.Entities;

namespace WarehouseManagement.Application.Features.Products.Commands.CreatePost
{
	public record CreatePostCommand(string Title, string Description, string Author, DateTime CreatedDate, DateTime UpdatedDate) : IRequest<Guid>;
}
