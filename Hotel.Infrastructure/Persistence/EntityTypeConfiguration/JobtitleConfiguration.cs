using Hotel.Domain.Room;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Hotel.Domain.JobTitle;

namespace Hotel.Infrastructure.Persistence.EntityTypeConfiguration;

public class JobtitleConfiguration : IEntityTypeConfiguration<JobtitleEntity>
{
	public void Configure(EntityTypeBuilder<JobtitleEntity> builder)
	{
		builder.HasKey(jobtitle => jobtitle.Id);
		builder.Property(jobtitle => jobtitle.JobTitle);
	}
}