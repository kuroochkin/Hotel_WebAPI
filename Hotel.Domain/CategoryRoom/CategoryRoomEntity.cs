using Hotel.Domain.Сonveniences;

namespace Hotel.Domain.CategoryRoom;

public class CategoryRoomEntity
{
	public Guid Id { get; set; }
	public string Category { get; set; }

	public int QuantityPersons { get; set; }

	public int QuantityRooms { get; set; }

	public string Description { get; set; }

	public decimal Price { get; set; }

	public СonvenienceEntity? Convenience { get; set; }

	public CategoryRoomEntity(
		string category, 
		string description, 
		int quantityPersons, 
		int quantityRooms, 
		decimal price)
	{
		Id = Guid.NewGuid();
		Category = category;
		Description = description;
		QuantityPersons = quantityPersons;
		QuantityRooms = quantityRooms;
		Price = price;
	}
}
