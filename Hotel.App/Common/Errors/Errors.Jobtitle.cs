using ErrorOr;

namespace Hotel.App.Common.Errors;

public static partial class Errors
{
	public static class Jobtitle
	{
		public static Error InvalidId => Error.Validation(
			code: "Jobtitle.InvalidId",
			description: "Id должности не найдено.");

		public static Error NotFound => Error.Validation(
			code: "Jobtitle.NotFound",
			description: "Должность не найдена.");
	}
}
