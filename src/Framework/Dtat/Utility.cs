//namespace Dtat;

//public static class Utility : object
//{
//	static Utility()
//	{
//	}

//	public static System.DateTimeOffset Now
//	{
//		get
//		{
//			//var result =
//			//	System.DateTimeOffset.Now;

//			//return result;

//			var currentCulture =
//				System.Threading.Thread
//				.CurrentThread.CurrentCulture;

//			var currentUICulture =
//				System.Threading.Thread
//				.CurrentThread.CurrentUICulture;

//			var englishCulture =
//				new System.Globalization
//				.CultureInfo(name: "en-US");

//			System.Threading.Thread
//				.CurrentThread.CurrentCulture = englishCulture;

//			System.Threading.Thread
//				.CurrentThread.CurrentUICulture = englishCulture;

//			var result =
//				System.DateTimeOffset.UtcNow;

//			System.Threading.Thread
//				.CurrentThread.CurrentCulture = currentCulture;

//			System.Threading.Thread
//				.CurrentThread.CurrentUICulture = currentUICulture;

//			return result;
//		}
//	}

//	public static string? RemoveSpaces(string? text)
//	{
//		if (string.IsNullOrWhiteSpace(value: text))
//		{
//			return null;
//		}

//		text =
//			text.Trim();

//		text = text.Replace
//			(oldValue: " ", newValue: string.Empty);

//		return text;
//	}

//	public static string? RemoveSpacesAndMakeTextCaseInsensitive(string? text)
//	{
//		text =
//			RemoveSpaces(text: text);

//		if (string.IsNullOrWhiteSpace(value: text))
//		{
//			return text;
//		}

//		text =
//			text.ToLower();

//		return text;
//	}
//}
