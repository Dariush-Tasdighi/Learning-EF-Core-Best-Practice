namespace Dtat.Seedwork.Abstractions;

public interface IEntityIdIsSetable<TIdentity> where TIdentity : struct
{
	void SetId(TIdentity id);
}
