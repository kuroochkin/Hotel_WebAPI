using ErrorOr;
using MediatR;

namespace Hotel.App.CategoryRoom.Commands.AddConvenience;

public record AddConvenienceCommand(
	string CategoryId,
	string ConvenienceId) : IRequest<ErrorOr<bool>>;

