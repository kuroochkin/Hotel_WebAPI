using ErrorOr;

namespace Hotel.App.Common.Errors;

public static partial class Errors
{
	public static class Category
	{
		public static Error InvalidId => Error.Validation(
			code: "Category.InvalidId",
			description: "Id категории номера не найден.");

		public static Error NotFound => Error.Validation(
			code: "Category.NotFound",
			description: "Категория номера не найден.");
	}
}
