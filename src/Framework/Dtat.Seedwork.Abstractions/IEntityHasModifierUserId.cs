namespace Dtat.Seedwork.Abstractions;

public interface IEntityHasModifierUserId<TIdentity> where TIdentity : struct
{
	TIdentity? ModifierUserId { get; }

	System.DateTimeOffset UpdateDateTime { get; }

	void Update(TIdentity modifierUserId);
}
