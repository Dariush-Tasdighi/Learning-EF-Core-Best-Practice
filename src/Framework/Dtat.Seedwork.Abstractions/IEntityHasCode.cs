namespace Dtat.Seedwork.Abstractions;

public interface IEntityHasCode<TCode> where TCode : struct
{
	TCode Code { get; }
}
