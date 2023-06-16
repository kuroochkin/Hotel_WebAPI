using Hotel.Domain.JobTitle;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Hotel.Domain.Client;

namespace Hotel.Infrastructure.Persistence.EntityTypeConfiguration;

public class ClientConfiguration : IEntityTypeConfiguration<ClientEntity>
{
	public void Configure(EntityTypeBuilder<ClientEntity> builder)
	{
		builder.HasKey(client => client.Id);
		builder.Property(client => client.LastName);
		builder.Property(client => client.FirstName);
		builder.Property(client => client.Patronymic);
		builder.Property(client => client.Birthday);
		builder.Property(client => client.Sex);
	}
}
