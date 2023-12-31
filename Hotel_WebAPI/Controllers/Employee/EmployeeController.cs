﻿using Hotel.App.Employee.Commands.CreateEmployee;
using Hotel.App.Employee.Queries.GetEmployeeDetails;
using Hotel.Contracts.Employee.Get;
using Hotel.Contracts.Employee.Requests;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace Hotel.API.Controllers.Employee;

[ApiController]
[Route("api/employee")]
public class EmployeeController : ControllerBase
{
	private readonly ISender _mediator;
	private readonly IMapper _mapper;

	public EmployeeController(ISender mediator, IMapper mapper)
	{
		_mediator = mediator;
		_mapper = mapper;
	}

	[HttpGet("{employeeId}")]
	public async Task<IActionResult> GetDetailsEmployee(string employeeId)
	{
		var query = new GetEmployeeDetailsQuery(employeeId);

		var employeeResult = await _mediator.Send(query);

		return employeeResult.Match(
			employee => Ok(_mapper.Map<EmployeeResponse>(employee)),
			errors => Problem("Ошибка")
		);
	}

	[HttpPost("create")]
	public async Task<IActionResult> CreateEmployee(CreateEmployeeRequest request)
	{
		var command = _mapper.Map<CreateEmployeeCommand>(request);

		var result = await _mediator.Send(command);

		return result.Match(
			employeeResult => Ok(result.Value),
			errors => Problem("Ошибка")
			);
	}
}
