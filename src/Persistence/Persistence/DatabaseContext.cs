using System.Linq;
using Persistence.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class DatabaseContext :
	Microsoft.EntityFrameworkCore.DbContext
{
	#region Constructor
	public DatabaseContext() : base()
	{
	}

	//public DatabaseContext(Microsoft.EntityFrameworkCore
	//	.DbContextOptions<DatabaseContext> options) : base(options: options)
	//{
	//	// تا قبل از اولین نسخه اصلی
	//	//Database.EnsureCreated();

	//	// نوشتن دستورات ذیل کامل غلط است
	//	// لااقل در اولین باری که بانک‌اطلاعاتی
	//	// می‌خواهد ایجاد شود، کار نمی‌کند
	//	//// using Microsoft.EntityFrameworkCore;
	//	//if (Database.GetAppliedMigrations().Any())
	//	//{
	//	//	// using Microsoft.EntityFrameworkCore;
	//	//	Database.Migrate();
	//	//}

	//	// using Microsoft.EntityFrameworkCore;
	//	Database.Migrate();
	//}
	#endregion /Constructor

	#region Properties

	#region Identity Feature

	public Microsoft.EntityFrameworkCore.DbSet<Domain.Features.Identity.Role> Roles { get; set; }
	public Microsoft.EntityFrameworkCore.DbSet<Domain.Features.Identity.User> Users { get; set; }
	public Microsoft.EntityFrameworkCore.DbSet<Domain.Features.Identity.Group> Groups { get; set; }

	/// <summary>
	/// نکته مهم: معمولا نمی‌نویسیم
	/// </summary>
	//public Microsoft.EntityFrameworkCore.DbSet<Domain.Features.Identity.UserProfile> UserProfiles { get; set; }

	#endregion /Identity Feature

	#endregion /Properties

	#region Methods

	protected override void OnConfiguring
		(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
	{
		var connectionString =
			"Server=.;User ID=sa;Password=1234512345;Database=LEARNING_EF_CORE_MIGRATION;MultipleActiveResultSets=true;TrustServerCertificate=True;";

		// UseSqlServer -> using Microsoft.EntityFrameworkCore;
		optionsBuilder.UseSqlServer
			(connectionString: connectionString);
	}

	#region OnModelCreating()
	protected override void OnModelCreating
		(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
	{
		// Learning Fluent API

		// Solution (1)
		//modelBuilder
		//	.Entity<Domain.Features.Identity.User>()
		//	.HasIndex(current => new { current.Username })
		//	.IsUnique(unique: true)
		//	;
		// /Solution (1)

		// Solution (2)
		//modelBuilder.ApplyConfiguration(configuration:
		//	new Configurations.Features.Idenity.UserConfiguration());
		// /Solution (2)

		// Solution (3)
		//new Configurations.Features.Idenity.UserConfiguration()
		//	.Configure(builder: modelBuilder.Entity<Domain.Features.Identity.User>());
		// /Solution (3)

		// Solution (4)
		//modelBuilder.ApplyConfigurationsFromAssembly
		//	(assembly: System.Reflection.Assembly.GetExecutingAssembly());
		// /Solution (4)

		// Solution (5)
		//modelBuilder.ApplyConfigurationsFromAssembly
		//	(assembly: typeof(Configurations.Features.Idenity.UserConfiguration).Assembly);
		// /Solution (5)

		// Solution (6)
		modelBuilder.ApplyConfigurationsFromAssembly
			(assembly: typeof(DatabaseContext).Assembly);
		// /Solution (6)

		if (Database.ProviderName == "Microsoft.EntityFrameworkCore.Sqlite")
		{
			// SQLite does not have proper support for DateTimeOffset via Entity Framework Core, see the limitations
			// here: https://docs.microsoft.com/en-us/ef/core/providers/sqlite/limitations#query-limitations
			// To work around this, when the Sqlite database provider is used, all model properties of type DateTimeOffset
			// use the DateTimeOffsetToBinaryConverter
			// Based on: https://github.com/aspnet/EntityFrameworkCore/issues/10784#issuecomment-415769754
			// This only supports millisecond precision, but should be sufficient for most use cases.
			foreach (var entityType in modelBuilder.Model.GetEntityTypes())
			{
				var properties =
					entityType.ClrType.GetProperties()
					.Where(current =>
						current.PropertyType == typeof(System.DateTimeOffset) ||
						current.PropertyType == typeof(System.DateTimeOffset?));

				foreach (var property in properties)
				{
					modelBuilder
						.Entity(name: entityType.Name)
						.Property(propertyName: property.Name)
						.HasConversion(converter:
							new Microsoft.EntityFrameworkCore
							.Storage.ValueConversion.DateTimeOffsetToBinaryConverter());
				}
			}
		}

		modelBuilder.Seed();
	}
	#endregion /OnModelCreating()

	#endregion /Methods
}
