namespace Hotel.Domain.CategoryRoom;

public class CategoryRoomEntity
{
	public Guid Id { get; set; }
	public string Category { get; set; }

	public int QuantityPersons { get; set; }

	public int QuantityRooms {get; set; }

	public string Description { get; set; }

	public decimal Price { get; set; }
}
