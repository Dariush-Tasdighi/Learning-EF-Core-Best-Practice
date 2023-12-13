namespace Dtat.Seedwork.Abstractions;

public interface IEntityHasIsVerified<TIdentity> where TIdentity : struct
{
	bool IsVerified { get; }

	TIdentity? VerifierUserId { get; }

	System.DateTimeOffset? VerifyDateTime { get; }

	void Verify(TIdentity verifierUserId);

	void Unverify(TIdentity verifierUserId);
}
