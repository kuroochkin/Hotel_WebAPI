using ErrorOr;

namespace Hotel.App.Common.Errors;

public static partial class Errors
{
	public static class Convenience
	{
		public static Error InvalidId => Error.Validation(
			code: "Convenience.InvalidId",
			description: "Id списка услуг не найден.");

		public static Error NotFound => Error.Validation(
			code: "Convenience.NotFound",
			description: "Список услуг не найден.");
	}
}

