using Azure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

namespace Persistence.Configurations.Features.Idenity;

internal sealed class GroupConfiguration : object, Microsoft
	.EntityFrameworkCore.IEntityTypeConfiguration<Domain.Features.Identity.Group>
{
	public GroupConfiguration() : base()
	{
	}

	public void Configure
		(Microsoft.EntityFrameworkCore.Metadata
		.Builders.EntityTypeBuilder<Domain.Features.Identity.Group> builder)
	{
		// **************************************************
		// **************************************************
		// **************************************************
		builder
			.HasIndex(current => new { current.Title })
			.IsUnique(unique: true)
			;
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// https://learn.microsoft.com/en-us/ef/core/modeling/relationships/many-to-many
		// **************************************************
		//builder
		//	.HasMany(current => current.Users)
		//	.WithMany(other => other.Groups)
		//	;

		//builder
		//	.HasMany(current => current.Users)
		//	.WithMany(other => other.Groups)
		//	.UsingEntity(joinEntityName: "UsersInGroups")
		//	;

		// نکته بسیار مهم! ترتیب نوشتن دستورات ذیل بی‌نهایت اهمیت دارد
 		builder
			.HasMany(current => current.Users)
			.WithMany(other => other.Groups)
			.UsingEntity(joinEntityName: "UsersInGroups",
				left => left.HasOne(relatedType: typeof(Domain.Features.Identity.User))
					.WithMany()
					.HasForeignKey(foreignKeyPropertyNames: "UserId"),
				right => right.HasOne(relatedType: typeof(Domain.Features.Identity.Group))
					.WithMany()
					.HasForeignKey(foreignKeyPropertyNames: "GroupId")
				);
		// **************************************************
		// **************************************************
		// **************************************************
	}
}
