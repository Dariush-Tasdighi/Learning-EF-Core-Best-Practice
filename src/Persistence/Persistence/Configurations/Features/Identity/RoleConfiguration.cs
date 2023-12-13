namespace Persistence.Configurations.Features.Idenity;

internal sealed class RoleConfiguration : object, Microsoft
	.EntityFrameworkCore.IEntityTypeConfiguration<Domain.Features.Identity.Role>
{
	public RoleConfiguration() : base()
	{
	}

	public void Configure
		(Microsoft.EntityFrameworkCore.Metadata
		.Builders.EntityTypeBuilder<Domain.Features.Identity.Role> builder)
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
		// **************************************************
		// **************************************************
		builder
			.HasMany(current => current.Users)
			.WithOne(other => other.Role)
			.IsRequired(required: true)
			.HasForeignKey(other => other.RoleId)
			.OnDelete(deleteBehavior:
				Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
			;
		// **************************************************
		// **************************************************
		// **************************************************

		// User							1..N						Post
		// System.Guid Id											System.Guid Id

		// IList<Post> WrittenPosts									System.Guid WriterUserId
		//															User WritterUser

		// IList<Post> VerifiedPosts								System.Guid VerifierUserId
		//															User VerifierUser

		//builder
		//	.HasMany(current => current.WrittenPosts)
		//	.WithOne(other => other.WritterUser)
		//	.IsRequired(required: true)
		//	.HasForeignKey(other => other.WritterUserId)
		//	.OnDelete(deleteBehavior:
		//		Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
		//	;

		//builder
		//	.HasMany(current => current.VerifiedPosts)
		//	.WithOne(other => other.VerifierUser)
		//	.IsRequired(required: false)
		//	.HasForeignKey(other => other.VerifierUserId)
		//	.OnDelete(deleteBehavior:
		//		Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
		//	;
	}
}
