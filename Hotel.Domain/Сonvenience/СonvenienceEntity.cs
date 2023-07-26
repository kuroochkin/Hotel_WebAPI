namespace Hotel.Domain.Сonveniences;

public class СonvenienceEntity
{
	public Guid Id { get; set; }

	public bool Bathroom { get; set; }

	public bool Tv { get; set; }

	public bool AirConditioner { get; set; }

	public bool Fridge { get; set; }

	public bool HairDryer { get; set;  }

	public bool Kettle { get; set;  }

	public bool Iron { get; set; }

	public bool WiFi { get; set; }


	public СonvenienceEntity(
		bool bathroom,
		bool tv,
		bool airConditioner,
		bool fridge,
		bool hairDryer,
		bool kettle,
		bool iron,
		bool wiFi)
	{
		Id = Guid.NewGuid();
		Bathroom = bathroom;
		Tv = tv;
		AirConditioner = airConditioner;
		Fridge = fridge;
		HairDryer = hairDryer;
		Kettle = kettle;
		Iron = iron;
		WiFi = wiFi;
	}

	public СonvenienceEntity()
	{
	}
}


