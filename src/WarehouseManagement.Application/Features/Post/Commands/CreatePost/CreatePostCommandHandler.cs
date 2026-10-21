using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.Application.Interfaces.Repositories;
using WarehouseManagement.Domain.Entities;

namespace WarehouseManagement.Application.Features.Products.Commands.CreatePost
{
	public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, Guid>
	{
		private readonly IPostRepository _repository;

		public CreatePostCommandHandler(IPostRepository repository)
		{
			_repository = repository;
		}

		public async Task<Guid> Handle(CreatePostCommand request, CancellationToken cancellationToken)
		{
			var post = new Post(request.Title, request.Description, request.Author, request.CreatedDate, request.UpdatedDate);

			await _repository.AddAsync(post);

			return post.Id;
		}
	}
}
