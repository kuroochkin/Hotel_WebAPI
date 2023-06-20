using Hotel.App.Employee.Queries;
using Hotel.Contracts.Room.Get;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static Hotel.App.Common.Errors.Errors;

namespace Hotel.API.Controllers.Employee;

[ApiController]
[Route("api/employee")]
public class EmployeeController : ControllerBase
{
	private readonly ISender _mediator;
	private readonly IMapper _mapper;


	[HttpGet("{employeeId}")]
	public async Task<IActionResult> GetDetailsOrder(string employeeId)
	{
		var query = new GetEmployeeDetailsQuery(employeeId);

		var employeeResult = await _mediator.Send(query);

		return employeeResult.Match(
			employee => Ok(_mapper.Map<EmployeeResponse>(employee)),
			errors => Problem("Ошибка")
		);
	}
}
