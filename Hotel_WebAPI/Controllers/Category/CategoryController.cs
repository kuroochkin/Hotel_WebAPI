using Hotel.App.CategoryRoom.Commands.CreateCategory;
using Hotel.Contracts.CategoryRoom.Requests;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.API.Controllers.Category;

[ApiController]
[Route("api/category")]
public class CategoryController : ControllerBase
{
	private readonly ISender _mediator;
	private readonly IMapper _mapper;

	public CategoryController(ISender mediator, IMapper mapper)
	{
		_mediator = mediator;
		_mapper = mapper;
	}

	[HttpPost("create")]
	public async Task<IActionResult> CreateCategory(CreateCategoryRequest request)
	{
		var command = _mapper.Map<CreateCategoryCommand>(request);

		var result = await _mediator.Send(command);

		return result.Match(
			categoryResult => Ok(result.Value),
			errors => Problem("Ошибка")
			);
	}
}
