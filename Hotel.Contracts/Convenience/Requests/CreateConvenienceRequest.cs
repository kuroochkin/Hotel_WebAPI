namespace Hotel.Contracts.Convenience.Requests;

public record CreateConvenienceRequest(
	bool Bathroom,
	bool Tv,
	bool AirConditioner,
	bool Fridge,
	bool HairDryer,
	bool Kettle,
	bool Iron,
	bool WiFi);
