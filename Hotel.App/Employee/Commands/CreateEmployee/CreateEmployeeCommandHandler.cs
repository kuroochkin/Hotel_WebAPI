using ErrorOr;
using Hotel.App.Common.Errors;
using Hotel.App.Common.Interfaces;
using Hotel.Domain.Employee;
using MediatR;

namespace Hotel.App.Employee.Commands.CreateEmployee;

public class CreateEmployeeCommandHandler
	: IRequestHandler<CreateEmployeeCommand, ErrorOr<bool>>
{
	private readonly IUnitOfWork _unitOfWork;

	public CreateEmployeeCommandHandler(IUnitOfWork unitOfWork)
	{
		_unitOfWork = unitOfWork;
	}

	public async Task<ErrorOr<bool>> Handle(
		CreateEmployeeCommand request, 
		CancellationToken cancellationToken)
	{
		if (!Guid.TryParse(request.JobtitleId, out var jobtitleId))
		{
			return Errors.Jobtitle.InvalidId;
		}

		var jobtitle = await _unitOfWork.Jobtitles.FindById(jobtitleId);
		if(jobtitle is null)
		{
			return Errors.Jobtitle.NotFound;
		}

		var employee = new EmployeeEntity(
			request.LastName,
			request.FirstName,
			request.Patronymic,
			request.Birthday,
			request.Education,
			jobtitle,
			request.Salary);

		if (await _unitOfWork.Employees.Add(employee))
		{
			return await _unitOfWork.CompleteAsync();
		}

		return false;
	}
}
