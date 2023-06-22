using Hotel.Domain.JobTitle;

namespace Hotel.Domain.Employee;

public class EmployeeEntity
{
	public Guid Id { get; set; }
	public string LastName { get; set; }

	public string FirstName { get; set; }

	public string Patronymic { get; set; }

	public DateTime Birthday { get; set; }

	public string Education { get; set; }

	public JobtitleEntity JobTitle { get; set; }

	public decimal Salary { get; set; }

	public EmployeeEntity(
		string lastName, 
		string firstName, 
		string patronymic, 
		DateTime birthday, 
		string education, 
		JobtitleEntity jobTitle, 
		decimal salary)
	{
		Id = Guid.NewGuid();
		LastName = lastName;
		FirstName = firstName;
		Patronymic = patronymic;
		Birthday = birthday;
		Education = education;
		JobTitle = jobTitle;
		Salary = salary;
	}

	public EmployeeEntity()
	{

	}
}
