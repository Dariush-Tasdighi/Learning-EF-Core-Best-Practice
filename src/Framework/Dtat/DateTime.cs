namespace Dtat;

public static class DateTime : object
{
	static DateTime()
	{
	}

	/// <summary>
	/// https://nwb.one/blog/difference-between-datetime-now-utcnow
	/// https://learn.microsoft.com/en-us/dotnet/standard/datetime/converting-between-datetime-and-offset
	/// </summary>
	public static System.DateTimeOffset Now
	{
		get
		{
			//return System.DateTime.Now;

			//return System.DateTime.UtcNow;

			var currentCulture =
				System.Threading.Thread.CurrentThread.CurrentCulture;

			var currentUICulture =
				System.Threading.Thread.CurrentThread.CurrentUICulture;

			var englishCulture =
				new System.Globalization.CultureInfo(name: "en-US");

			System.Threading.Thread.CurrentThread.CurrentCulture = englishCulture;
			System.Threading.Thread.CurrentThread.CurrentUICulture = englishCulture;

			var result =
				System.DateTime.Now;

			//var result =
			//	System.DateTime.UtcNow;

			System.Threading.Thread.CurrentThread.CurrentCulture = currentCulture;
			System.Threading.Thread.CurrentThread.CurrentUICulture = currentUICulture;

			return result;
		}
	}
}
