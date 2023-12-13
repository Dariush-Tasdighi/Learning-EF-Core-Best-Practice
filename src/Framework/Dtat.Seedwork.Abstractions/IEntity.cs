namespace Dtat.Seedwork.Abstractions;

//public interface IEntity
//{
//	System.Guid Id { get; set; }
//}

//public interface IEntity<TIdentity>
//{
//	TIdentity Id { get; set; }
//}

//public interface IEntity<TIdentity>
//{
//	TIdentity Id { get; }
//}

public interface IEntity<TIdentity> where TIdentity : struct
{
	TIdentity Id { get; }
}
