using Hotel.Domain.Room;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Hotel.Domain.Employee;

namespace Hotel.Infrastructure.Persistence.EntityTypeConfiguration;

public class EmployeeConfiguration : IEntityTypeConfiguration<EmployeeEntity>
{
	public void Configure(EntityTypeBuilder<EmployeeEntity> builder)
	{
		builder.HasKey(employee => employee.Id);
		builder.Property(employee => employee.LastName);
		builder.Property(employee => employee.FirstName);
		builder.Property(employee => employee.Patronymic);
		builder.Property(employee => employee.Birthday);
		builder.Property(employee => employee.Education);
		builder.HasOne(employee => employee.JobTitle);
		builder.Property(employee => employee.Salary);
	}
}
