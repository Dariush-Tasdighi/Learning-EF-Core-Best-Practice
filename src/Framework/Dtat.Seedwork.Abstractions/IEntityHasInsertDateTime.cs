namespace Dtat.Seedwork.Abstractions;

public interface IEntityHasInsertDateTime
{
	System.DateTimeOffset InsertDateTime { get; }

	void Create();
}
