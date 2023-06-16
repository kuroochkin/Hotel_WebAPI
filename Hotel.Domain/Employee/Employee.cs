using Hotel.Domain.JobTitle;

namespace Hotel.Domain.Employee;

public class Employee
{
	public Guid Id { get; set; }
	public string LastName { get; set; }

	public string FirstName { get; set; }

	public string Patronymic { get; set; }

	public DateTime Birthday { get; set; }

	public string Education { get; set; }

	public Jobtitle JobTitle { get; set; }

	public decimal Salary { get; set; }







}
