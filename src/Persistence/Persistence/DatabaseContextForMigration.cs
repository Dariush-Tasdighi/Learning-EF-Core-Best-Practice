using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class DatabaseContextForMigration : DatabaseContextBase
{
	#region Constructor
	public DatabaseContextForMigration() : base()
	{
	}
	#endregion /Constructor

	#region Methods

	#region OnConfiguring
	protected override void OnConfiguring
		(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
	{
		var connectionString =
			"Server=.;User ID=sa;Password=1234512345;Database=LEARNING_EF_CORE_MIGRATION;MultipleActiveResultSets=true;TrustServerCertificate=True;";

		// UseSqlServer -> using Microsoft.EntityFrameworkCore;
		optionsBuilder.UseSqlServer
			(connectionString: connectionString);
	}
	#endregion /OnConfiguring

	#endregion /Methods
}
