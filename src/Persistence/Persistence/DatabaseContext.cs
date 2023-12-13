//namespace Persistence;

//public class DatabaseContext : DatabaseContextBase

//{
//	#region Constructor
//	public MainDatabaseContext(Microsoft.EntityFrameworkCore
//		.DbContextOptions<DatabaseContext> options) : base(options: options)
//	{
//	}
//	#endregion /Constructor
//}

namespace Persistence;

public class DatabaseContext
	(Microsoft.EntityFrameworkCore.DbContextOptions<DatabaseContext> options) :
	DatabaseContextBase(options: options)
{
}
