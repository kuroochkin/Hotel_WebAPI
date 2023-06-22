using ErrorOr;

namespace Hotel.App.Common.Errors;

public static partial class Errors
{
	public static class Employee
	{
		public static Error InvalidId => Error.Validation(
			code: "Employee.InvalidId",
			description: "Id сотрудника не найден.");

		public static Error NotFound => Error.Validation(
			code: "Employee.NotFound",
			description: "Сотрудник не найден.");
	}
}
