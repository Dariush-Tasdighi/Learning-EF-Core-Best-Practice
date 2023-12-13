namespace Domain.Seedwork;

public abstract class Entity : object,
	Dtat.Seedwork.Abstractions.IEntity<System.Guid>
{
	#region Constructor
	public Entity() : base()
	{
		Id = System.Guid.NewGuid();
	}
	#endregion /Constructor

	#region Properties

	#region public System.Guid Id { get; protected set; }
	/// <summary>
	/// شناسه
	/// </summary>
	[System.ComponentModel.DataAnnotations.Display
		(ResourceType = typeof(Resources.DataDictionary),
		Name = nameof(Resources.DataDictionary.Id))]

	[System.ComponentModel.DataAnnotations.Key]

	[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
		(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
	public System.Guid Id { get; protected set; }
	#endregion /public System.Guid Id { get; protected set; }

	#endregion /Properties
}
