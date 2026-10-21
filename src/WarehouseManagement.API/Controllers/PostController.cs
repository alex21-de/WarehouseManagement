using MediatR;
using Microsoft.AspNetCore.Mvc;
using WarehouseManagement.Application.Features.Products.Commands.CreatePost;

namespace WarehouseManagement.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class PostController : ControllerBase
	{
		private readonly IMediator _mediator;
		private readonly ILogger<PostController> _logger;

		public PostController(IMediator mediator, ILogger<PostController> logger)
		{
			_mediator = mediator;
			_logger = logger;
		}

		[HttpPost]
		public async Task<IActionResult> Create(CreatePostCommand command)
		{
			var id = await _mediator.Send(command);

			return Ok(id);
		}
	}
}
