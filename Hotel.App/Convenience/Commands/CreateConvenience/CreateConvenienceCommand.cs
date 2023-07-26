using ErrorOr;
using MediatR;

namespace Hotel.App.Convenience.Commands.CreateConvenience;

public record CreateConvenienceCommand(
	bool Bathroom,
	bool Tv,
	bool AirConditioner,
	bool Fridge,
	bool HairDryer,
	bool Kettle,
	bool Iron,
	bool WiFi) : IRequest<ErrorOr<bool>>;
