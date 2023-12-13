namespace Dtat;

public static class PersianDateExtensions : object
{
	static PersianDateExtensions()
	{
	}

	public static PersianDate ToPersianDate(this System.DateTimeOffset value)
	{
		var result =
			new PersianDate(dateTime: value);

		return result;
	}

	public static PersianDateTime ToPersianDateTime(this System.DateTimeOffset value)
	{
		var result =
			new PersianDateTime(dateTime: value);

		return result;
	}
}
