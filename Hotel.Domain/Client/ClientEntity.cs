namespace Hotel.Domain.Client;

public class ClientEntity
{
	public Guid Id { get; set; }

	public string LastName { get; set; }

	public string FirstName { get; set; }

	public string Patronymic { get; set; }

	public DateTime Birthday { get; set; }

	public string Sex { get; set; }

	public ClientEntity(string lastName, string firstName, string patronymic, DateTime birthday, string sex)
	{
		Id = Guid.NewGuid();
		LastName = lastName;
		FirstName = firstName;
		Patronymic = patronymic;
		Birthday = birthday;
		Sex = sex;
	}
}
