using ErrorOr;

namespace Hotel.App.Common.Errors;

public static partial class Errors
{
	public static class Room
	{
		public static Error InvalidId => Error.Validation(
			code: "Room.InvalidId",
			description: "Id номера не найден.");

		public static Error NotFound => Error.Validation(
			code: "Room.NotFound",
			description: "Номер не найден.");
	}
}
