namespace Dtat.Seedwork.Abstractions;

public interface IEntityHasCreatorUserId<TIdentity> where TIdentity : struct
{
	TIdentity CreatorUserId { get; }

	System.DateTimeOffset InsertDateTime { get; }

	void Create(TIdentity creatorUserId);
}
