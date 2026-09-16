using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WarehouseManagement.Application.Features.Category.Commands.CreateCategory;

namespace WarehouseManagement.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class CategoryController : ControllerBase
	{
		private readonly IMediator _mediator;

		public CategoryController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpPost]
		public async Task<IActionResult> Create(CreateCategoryCommand command)
		{
			var id = await _mediator.Send(command);

			return Ok(id);
		}
	}
}
