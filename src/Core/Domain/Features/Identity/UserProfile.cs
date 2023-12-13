namespace Domain.Features.Identity;

public class UserProfile : Seedwork.Entity
{
	#region Constructor
	public UserProfile(System.Guid userId) : base()
	{
		UserId = userId;
	}
	#endregion /Constructor

	#region Properties

	#region public System.Guid UserId { get; set; }
	/// <summary>
	/// کاربر
	/// </summary>
	[System.ComponentModel.DataAnnotations.Display
		(ResourceType = typeof(Resources.DataDictionary),
		Name = nameof(Resources.DataDictionary.User))]

	[System.ComponentModel.DataAnnotations.Required
		(AllowEmptyStrings = false,
		ErrorMessageResourceType = typeof(Resources.Messages.Validations),
		ErrorMessageResourceName = nameof(Resources.Messages.Validations.Required))]
	public System.Guid UserId { get; set; }
	#endregion /public System.Guid UserId { get; set; }

	#region public virtual User User { get; set; } = null!;
	/// <summary>
	/// کاربر
	/// </summary>
	[System.ComponentModel.DataAnnotations.Display
		(ResourceType = typeof(Resources.DataDictionary),
		Name = nameof(Resources.DataDictionary.User))]

	[System.ComponentModel.DataAnnotations.Required
		(AllowEmptyStrings = false,
		ErrorMessageResourceType = typeof(Resources.Messages.Validations),
		ErrorMessageResourceName = nameof(Resources.Messages.Validations.Required))]
	public virtual User User { get; set; } = null!;
	#endregion /public virtual User User { get; set; } = null!;

	#region public string? LastName { get; set; }
	/// <summary>
	/// نام خانوادگی
	/// </summary>
	[System.ComponentModel.DataAnnotations.Display
		(ResourceType = typeof(Resources.DataDictionary),
		Name = nameof(Resources.DataDictionary.LastName))]

	[System.ComponentModel.DataAnnotations.MaxLength
		(length: Dtat.Constants.MaxLength.LastName,
		ErrorMessageResourceType = typeof(Resources.Messages.Validations),
		ErrorMessageResourceName = nameof(Resources.Messages.Validations.MaxLength))]
	public string? LastName { get; set; }
	#endregion /public string? LastName { get; set; }

	#region public string? FirstName { get; set; }
	/// <summary>
	/// نام
	/// </summary>
	[System.ComponentModel.DataAnnotations.Display
		(ResourceType = typeof(Resources.DataDictionary),
		Name = nameof(Resources.DataDictionary.FirstName))]

	[System.ComponentModel.DataAnnotations.MaxLength
		(length: Dtat.Constants.MaxLength.FirstName,
		ErrorMessageResourceType = typeof(Resources.Messages.Validations),
		ErrorMessageResourceName = nameof(Resources.Messages.Validations.MaxLength))]
	public string? FirstName { get; set; }
	#endregion /public string? FirstName { get; set; }

	#endregion /Properties
}
