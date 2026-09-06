using MediatR;
using Microsoft.AspNetCore.Mvc;
using WarehouseManagement.Application.Features.Products.Commands.CreateProduct;

namespace WarehouseManagement.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{

    private readonly IMediator _mediator;
    private readonly ILogger<ProductController> _logger;

    public ProductController(IMediator mediator, ILogger<ProductController> logger)
    {
        _mediator = mediator;
        _logger = logger;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateProductCommand command)
    {
        var id = await _mediator.Send(command);

        return Ok(id);
    }
}
