namespace Dtat.Seedwork.Abstractions;

public interface IEntityHasOrdering<IOrdering> where IOrdering : struct
{
	IOrdering Ordering { get; }
}
