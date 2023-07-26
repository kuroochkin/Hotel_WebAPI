using MapsterMapper;
using Hotel.App.Convenience.Commands.CreateConvenience;
using Hotel.Contracts.Convenience.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.API.Controllers.Convenience;

[ApiController]
[Route("api/convenience")]
public class ConvenienceController : ControllerBase
{
	private readonly ISender _mediator;
	private readonly IMapper _mapper;

	public ConvenienceController(ISender mediator, IMapper mapper)
	{
		_mediator = mediator;
		_mapper = mapper;
	}

	[HttpPost("create")]
	public async Task<IActionResult> CreateConvenience(CreateConvenienceRequest request)
	{
		var command = _mapper.Map<CreateConvenienceCommand>(request);

		var result = await _mediator.Send(command);

		return result.Match(
			convenienceResult => Ok(result.Value),
			errors => Problem("Ошибка")
			);
	}
}
