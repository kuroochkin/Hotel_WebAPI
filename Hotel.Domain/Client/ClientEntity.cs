namespace Hotel.Domain.Client;

public class ClientEntity
{
	public Guid Id { get; set; }

	public string LastName { get; set; }

	public string FirstName { get; set; }

	public string Patronymic { get; set; }

	public DateTime Birthday { get; set; }

	public string Sex { get; set; }
}
