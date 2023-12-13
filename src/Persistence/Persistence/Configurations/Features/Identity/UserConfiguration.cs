namespace Persistence.Configurations.Features.Idenity;

internal sealed class UserConfiguration : object, Microsoft
	.EntityFrameworkCore.IEntityTypeConfiguration<Domain.Features.Identity.User>
{
	public UserConfiguration() : base()
	{
	}

	//public void Configure
	//	(Microsoft.EntityFrameworkCore.Metadata
	//	.Builders.EntityTypeBuilder<Domain.Features.Identity.User> builder)
	//{
	//}

	public void Configure
		(Microsoft.EntityFrameworkCore.Metadata
		.Builders.EntityTypeBuilder<Domain.Features.Identity.User> builder)
	{
		// **************************************************
		// **************************************************
		// **************************************************
		builder
			.Property(current => current.EmailAddress)
			.IsUnicode(unicode: false)
			;

		//builder
		//	.HasIndex(current => current.EmailAddress)
		//	.IsUnique(unique: true)
		//	;

		builder
			.HasIndex(current => new { current.EmailAddress })
			.IsUnique(unique: true)
			;
		// **************************************************

		// **************************************************
		builder
			.HasIndex(current => new { current.EmailAddressVerificationKey })
			.IsUnique(unique: true)
			;
		// **************************************************

		// **************************************************
		builder
			.Property(current => current.Password)
			.IsUnicode(unicode: false)
			;
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// https://learn.microsoft.com/en-us/ef/core/modeling/relationships/one-to-one
		// **************************************************
		builder
			.HasOne(current => current.Profile)
			.WithOne(other => other.User)
			.HasForeignKey<Domain.Features.Identity.UserProfile>(other => other.UserId)
			.IsRequired(required: true)
			;
		// **************************************************
		// **************************************************
		// **************************************************
	}
}
