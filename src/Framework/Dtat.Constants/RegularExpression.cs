namespace Dtat.Constants;

/// <summary>
/// https://regex101.com/
/// </summary>
public static class RegularExpression : object
{
	static RegularExpression()
	{
	}

	public const string JustDigits = @"^[0-9]+$";
	public const string NationalCode = @"^\d{10}$";
	//public const string NationalCode = @"^\d{10,12}$";

	//public const string CellPhoneNumber = @"^09\d{9}";
	//public const string CellPhoneNumber = @"^076\d{7}"; // برای سوئد

	// 0046762122002	: 13
	// 00989121087461	: 14
	//public const string CellPhoneNumber = @"^00\d{11,12}$"; // برای سایت‌های چند ملیتی
	public const string CellPhoneNumber = @"^00\d{12}$"; // برای ایران

	public const string Username = @"^[a-zA-Z0-9_]{6,20}$";
	public const string Password = @"^[a-zA-Z0-9_!@#$%^&]{8,20}$";
	public const string UsernameOrEmailAddress = @"^[a-zA-Z0-9_@.]{6,254}$";

	public const string Theme = @"^[a-z][a-z_]*$";
	public const string Color = @"^#[a-fA-F0-9]{4,7}$"; // #fff #11C79F

	//public const string AToZDigitsUnderline = @"^[a-zA-Z0-9_]*$";
	public const string AToZDigitsUnderline = @"^[a-zA-Z][a-zA-Z0-9_]*$";

	public const string EmailAddress =
		@"^[a-zA-Z0-9_.-]+@[a-zA-Z0-9_.-]+$";

	public const string IP =
		@"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";

	public const string Url =
		@"https?:\/\/(www\.)?[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b([-a-zA-Z0-9()@:%_\+.~#?&//=]*)";
}
