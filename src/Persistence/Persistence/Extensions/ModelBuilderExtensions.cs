namespace Persistence.Extensions;

internal static class ModelBuilderExtensions : object
{
	#region Static Constructor
	static ModelBuilderExtensions()
	{
		// **************************************************
		RoleUser =
			new Domain.Features.Identity.Role(title: "User")
			{
				IsActive = true,
			};

		RoleUser.Create();

		// **************************************************

		// **************************************************
		RoleAdministrator =
			new Domain.Features.Identity.Role(title: "Administrator")
			{
				IsActive = true,
			};

		RoleAdministrator.Create();
		// **************************************************
	}
	#endregion /Static Constructor

	#region Properties
	private static Domain.Features.Identity.Role RoleUser { get; set; }
	private static Domain.Features.Identity.Role RoleAdministrator { get; set; }
	#endregion /Properties

	#region Methods

	#region Seed()
	public static void Seed(this
		Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
	{
		SeedGroups(modelBuilder: modelBuilder);

		SeedRoles(modelBuilder: modelBuilder);

		SeedUsers(modelBuilder: modelBuilder);
	}
	#endregion /Seed()

	#region SeedRoles()
	private static void SeedRoles
		(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
	{
		// **************************************************
		modelBuilder.Entity<Domain.Features
			.Identity.Role>().HasData(data: RoleUser);
		// **************************************************

		// **************************************************
		modelBuilder.Entity<Domain.Features
			.Identity.Role>().HasData(data: RoleAdministrator);
		// **************************************************
	}
	#endregion /SeedRoles()

	#region SeedGroups()
	private static void SeedGroups
		(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
	{
		Domain.Features.Identity.Group group;

		// **************************************************
		group =
			new Domain.Features.Identity.Group(title: "Group 1")
			{
				IsActive = true,
			};

		group.Create();

		modelBuilder.Entity<Domain.Features
			.Identity.Group>().HasData(data: group);
		// **************************************************

		// **************************************************
		group =
			new Domain.Features.Identity.Group(title: "Group 2")
			{
				IsActive = true,
			};

		group.Create();

		modelBuilder.Entity<Domain.Features
			.Identity.Group>().HasData(data: group);
		// **************************************************

		// **************************************************
		group =
			new Domain.Features.Identity.Group(title: "Group 3")
			{
				IsActive = true,
			};

		group.Create();

		modelBuilder.Entity<Domain.Features
			.Identity.Group>().HasData(data: group);
		// **************************************************
	}
	#endregion /SeedGroups()

	#region SeedUsers()
	private static void SeedUsers
		(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
	{
		Domain.Features.Identity.User user;

		// **************************************************
		user =
			new Domain.Features.Identity.User(roleId: RoleAdministrator.Id,
			emailAddress: "DariushT@GMail.com", password: "1234512345")
			{
				IsActive = true,
			};

		user.Create();

		modelBuilder.Entity<Domain.Features
			.Identity.User>().HasData(data: user);
		// **************************************************

		// **************************************************
		user =
			new Domain.Features.Identity.User(roleId: RoleUser.Id,
			emailAddress: "AliRezaAlavi@GMail.com", password: "1234512345")
			{
				IsActive = true,
			};

		user.Create();

		modelBuilder.Entity<Domain.Features
			.Identity.User>().HasData(data: user);
		// **************************************************
	}
	#endregion /SeedUsers()

	#endregion /Methods
}
