namespace Dtat.Seedwork.Abstractions;

public interface IEntityHasIsSynced
{
	bool IsSynced { get; }

	System.DateTimeOffset? SyncDateTime { get; }
}
