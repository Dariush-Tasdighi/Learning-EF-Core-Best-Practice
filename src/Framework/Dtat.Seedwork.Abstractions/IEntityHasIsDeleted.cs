namespace Dtat.Seedwork.Abstractions;

public interface IEntityHasIsDeleted<TIdentity> where TIdentity : struct
{
	bool IsDeleted { get; }

	TIdentity? RemoverUserId { get; }

	System.DateTimeOffset? DeleteDateTime { get; }

	void Delete(TIdentity removerUserId);

	void Undelete(TIdentity removerUserId);
}
