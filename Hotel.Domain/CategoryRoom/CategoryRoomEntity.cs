namespace Hotel.Domain.CategoryRoom;

public class CategoryRoomEntity
{
	public Guid Id { get; set; }
	public string Category { get; set; }

	public int QuantityPersons { get; set; }

	public int QuantityRooms { get; set; }

	public string Description { get; set; }

	public decimal Price { get; set; }

	public bool Bathroom { get; }

	public bool Tv { get; }

	public bool AirConditioner { get; }

	public bool Fridge { get; }

	public bool HairDryer { get; }

	public bool Kettle {get;}

	public bool Iron { get; }

	public bool WiFi { get; }
}
