namespace Dtat.Seedwork.Abstractions;

public interface IEntityHasCultureId<TIdentity> where TIdentity : struct
{
	TIdentity CultureId { get; }
}
