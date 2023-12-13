namespace Domain.Features.Identity;

public class User :
	Seedwork.Entity,
	Dtat.Seedwork.Abstractions.IEntityHasIsActive,
	Dtat.Seedwork.Abstractions.IEntityHasInsertDateTime,
	Dtat.Seedwork.Abstractions.IEntityHasUpdateDateTime
{
	#region Constructor
	///// <summary>
	///// Default Constructor
	///// </summary>
	//public User() : base()
	//{
	//}

	public User(System.Guid roleId, string emailAddress, string password) : base()
	{
		ResetVerificationKey();
		SetPassword(password: password);

		RoleId = roleId;
		EmailAddress = emailAddress.ToLower();
	}
	#endregion /Constructor

	#region Properties

	#region public System.Guid RoleId { get; set; }
	/// <summary>
	/// نقش کاربر
	/// </summary>
	[System.ComponentModel.DataAnnotations.Display
		(ResourceType = typeof(Resources.DataDictionary),
		Name = nameof(Resources.DataDictionary.Role))]

	[System.ComponentModel.DataAnnotations.Required
		(AllowEmptyStrings = false,
		ErrorMessageResourceType = typeof(Resources.Messages.Validations),
		ErrorMessageResourceName = nameof(Resources.Messages.Validations.Required))]
	public System.Guid RoleId { get; set; }
	#endregion /public System.Guid RoleId { get; set; }

	#region public virtual Role Role { get; set; } = null!;
	/// <summary>
	/// نقش کاربر
	/// </summary>
	[System.ComponentModel.DataAnnotations.Display
		(ResourceType = typeof(Resources.DataDictionary),
		Name = nameof(Resources.DataDictionary.Role))]

	[System.ComponentModel.DataAnnotations.Required
		(AllowEmptyStrings = false,
		ErrorMessageResourceType = typeof(Resources.Messages.Validations),
		ErrorMessageResourceName = nameof(Resources.Messages.Validations.Required))]
	public virtual Role Role { get; set; } = null!;
	#endregion /public virtual Role Role { get; set; } = null!;

	#region public virtual UserProfile? Profile { get; set; }
	/// <summary>
	/// اطلاعات کاربر
	/// </summary>
	[System.ComponentModel.DataAnnotations.Display
		(ResourceType = typeof(Resources.DataDictionary),
		Name = nameof(Resources.DataDictionary.Profile))]
	public virtual UserProfile? Profile { get; set; }
	#endregion /public virtual UserProfile? Profile { get; set; }



	#region public bool IsActive { get; set; }
	/// <summary>
	/// وضعیت
	/// </summary>
	[System.ComponentModel.DataAnnotations.Display
		(ResourceType = typeof(Resources.DataDictionary),
		Name = nameof(Resources.DataDictionary.IsActive))]
	public bool IsActive { get; set; }
	#endregion /public bool IsActive { get; set; }

	#region public bool IsEmailAddressVerified { get; set; }
	/// <summary>
	/// نشانی پست الکترونیکی تایید شده است
	/// </summary>
	[System.ComponentModel.DataAnnotations.Display
		(ResourceType = typeof(Resources.DataDictionary),
		Name = nameof(Resources.DataDictionary.IsEmailAddressVerified))]
	public bool IsEmailAddressVerified { get; set; }
	#endregion /public bool IsEmailAddressVerified { get; set; }



	#region public string EmailAddress { get; set; }
	/// <summary>
	/// نشانی پست الکترونیکی
	/// </summary>
	//[System.ComponentModel.DataAnnotations.Display
	//	(Name = "Email Address")]

	//[System.ComponentModel.DataAnnotations.Display
	//	(Name = "نشانی پست الکترونیکی")]

	//[System.ComponentModel.DataAnnotations.Display
	//	(ResourceType = typeof(Resources.DataDictionary),
	//	Name = "EmailAddress")]

	// اگر سوتی بدهم
	//[System.ComponentModel.DataAnnotations.Display
	//	(ResourceType = typeof(Resources.DataDictionary),
	//	Name = "EmailAdress")]

	// اگر سوتی بدهم
	//[System.ComponentModel.DataAnnotations.Display
	//	(ResourceType = typeof(Resources.DataDictionary),
	//	Name = nameof(Resources.DataDictionary.EmailAdress))]

	[System.ComponentModel.DataAnnotations.Display
		(ResourceType = typeof(Resources.DataDictionary),
		Name = nameof(Resources.DataDictionary.EmailAddress))]

	//[System.ComponentModel.DataAnnotations.Required]

	//[System.ComponentModel.DataAnnotations.Required
	//	(AllowEmptyStrings = false)]

	//[System.ComponentModel.DataAnnotations.Required
	//	(AllowEmptyStrings = false,
	//	ErrorMessage = "You did not specify Email Address!")]

	//[System.ComponentModel.DataAnnotations.Required
	//	(AllowEmptyStrings = false,
	//	ErrorMessage = "You did not specify {0}!")]

	//[System.ComponentModel.DataAnnotations.Required
	//	(AllowEmptyStrings = false,
	//	ErrorMessageResourceType = typeof(Resources.Messages.Validations),
	//	ErrorMessageResourceName = "Required")]

	// اگر سوتی بدهم
	//[System.ComponentModel.DataAnnotations.Required
	//	(AllowEmptyStrings = false,
	//	ErrorMessageResourceType = typeof(Resources.Messages.Validations),
	//	ErrorMessageResourceName = "Requred")]

	[System.ComponentModel.DataAnnotations.Required
		(AllowEmptyStrings = false,
		ErrorMessageResourceType = typeof(Resources.Messages.Validations),
		ErrorMessageResourceName = nameof(Resources.Messages.Validations.Required))]

	//[System.ComponentModel.DataAnnotations.MaxLength
	//	(length: 254)]

	//[System.ComponentModel.DataAnnotations.MaxLength
	//	(length: Dtat.Constants.MaxLength.EmailAddress)]

	[System.ComponentModel.DataAnnotations.MaxLength
		(length: Dtat.Constants.MaxLength.EmailAddress,
		ErrorMessageResourceType = typeof(Resources.Messages.Validations),
		ErrorMessageResourceName = nameof(Resources.Messages.Validations.MaxLength))]

	//[System.ComponentModel.DataAnnotations.RegularExpression
	//	(pattern: Dtat.Constants.RegularExpression.EmailAddress)]

	[System.ComponentModel.DataAnnotations.RegularExpression
		(pattern: Dtat.Constants.RegularExpression.EmailAddress,
		ErrorMessageResourceType = typeof(Resources.Messages.Validations),
		ErrorMessageResourceName = nameof(Resources.Messages.Validations.EmailAddress))]
	public string EmailAddress { get; set; }
	//public string? EmailAddress { get; set; }
	#endregion /public string EmailAddress { get; set; }

	#region public string Password { get; private set; }
	/// <summary>
	/// گذرواژه
	/// </summary>
	[System.ComponentModel.DataAnnotations.Display
		(ResourceType = typeof(Resources.DataDictionary),
		Name = nameof(Resources.DataDictionary.Password))]

	[System.ComponentModel.DataAnnotations.Required
		(AllowEmptyStrings = false,
		ErrorMessageResourceType = typeof(Resources.Messages.Validations),
		ErrorMessageResourceName = nameof(Resources.Messages.Validations.Required))]

	[System.ComponentModel.DataAnnotations.MinLength
		(length: Dtat.Constants.FixedLength.DatabasePassword,
		ErrorMessageResourceType = typeof(Resources.Messages.Validations),
		ErrorMessageResourceName = nameof(Resources.Messages.Validations.MaxLength))]

	[System.ComponentModel.DataAnnotations.MaxLength
		(length: Dtat.Constants.FixedLength.DatabasePassword,
		ErrorMessageResourceType = typeof(Resources.Messages.Validations),
		ErrorMessageResourceName = nameof(Resources.Messages.Validations.MaxLength))]
	public string Password { get; private set; } = string.Empty;
	#endregion /public string Password { get; private set; }



	#region public System.DateTimeOffset InsertDateTime { get; private set; }
	/// <summary>
	/// زمان ایجاد
	/// </summary>
	[System.ComponentModel.DataAnnotations.Display
		(ResourceType = typeof(Resources.DataDictionary),
		Name = nameof(Resources.DataDictionary.InsertDateTime))]

	[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
		(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
	public System.DateTimeOffset InsertDateTime { get; private set; }
	#endregion /public System.DateTimeOffset InsertDateTime { get; private set; }

	#region public System.DateTimeOffset UpdateDateTime { get; private set; }
	/// <summary>
	/// زمان ویرایش
	/// </summary>
	[System.ComponentModel.DataAnnotations.Display
		(ResourceType = typeof(Resources.DataDictionary),
		Name = nameof(Resources.DataDictionary.UpdateDateTime))]

	[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
		(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
	public System.DateTimeOffset UpdateDateTime { get; private set; }
	#endregion /public System.DateTimeOffset UpdateDateTime { get; private set; }



	#region public System.Guid EmailAddressVerificationKey { get; private set; }
	/// <summary>
	/// کد تایید نشانی پست الکترونیکی
	/// </summary>
	[System.ComponentModel.DataAnnotations.Display
		(ResourceType = typeof(Resources.DataDictionary),
		Name = nameof(Resources.DataDictionary.EmailAddressVerificationKey))]
	public System.Guid EmailAddressVerificationKey { get; private set; }
	#endregion /public System.Guid EmailAddressVerificationKey { get; private set; }

	//#region public string? AdminDescription { get; set; }
	///// <summary>
	///// توضیحات مدیریتی
	///// </summary>
	//[System.ComponentModel.DataAnnotations.Display
	//	(ResourceType = typeof(Resources.DataDictionary),
	//	Name = nameof(Resources.DataDictionary.AdministratorDescription))]
	//public string? AdminDescription { get; set; }
	//#endregion /public string? AdminDescription { get; set; }

	//#region public string? AdministratorDescription { get; set; }
	///// <summary>
	///// توضیحات مدیریتی
	///// </summary>
	//[System.ComponentModel.DataAnnotations.Display
	//	(ResourceType = typeof(Resources.DataDictionary),
	//	Name = nameof(Resources.DataDictionary.AdministratorDescription))]
	//public string? AdministratorDescription { get; set; }
	//#endregion /public string? AdministratorDescription { get; set; }

	#endregion /Properties

	#region Methods

	#region Create()
	public void Create()
	{
		InsertDateTime =
			Dtat.DateTime.Now;

		UpdateDateTime =
			InsertDateTime;
	}
	#endregion /Create()

	#region Update()
	public void Update()
	{
		UpdateDateTime =
			Dtat.DateTime.Now;
	}
	#endregion /Update()

	#region SetPassword()
	public void SetPassword(string password)
	{
		Password =
			Dtat.Security.Hashing.GetSha256(value: password);
	}
	#endregion /SetPassword()

	#region ResetVerificationKey()
	public void ResetVerificationKey()
	{
		EmailAddressVerificationKey = System.Guid.NewGuid();
	}
	#endregion /ResetVerificationKey()

	#endregion /Methods

	#region Collections

	public virtual System.Collections.Generic.List<Group> Groups { get; private set; } = [];

	#endregion /Collections
}
