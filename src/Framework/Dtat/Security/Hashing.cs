namespace Dtat.Security;

public static class Hashing : object
{
	static Hashing()
	{
	}

	//public static string GetSha256(string text)
	//{
	//	var inputBytes =
	//		System.Text.Encoding.UTF8.GetBytes(s: text);

	//	var sha =
	//		System.Security.Cryptography.SHA256.Create();

	//	var outputBytes =
	//		sha.ComputeHash(buffer: inputBytes);

	//	sha.Dispose();
	//	//sha = null;

	//	var result =
	//		System.Convert.ToBase64String(inArray: outputBytes);

	//	return result;
	//}

	//public static string GetSha256(string text)
	//{
	//	var inputBytes =
	//		System.Text.Encoding.UTF8.GetBytes(s: text);

	//	string result;

	//	using (var sha = System.Security.Cryptography.SHA256.Create())
	//	{
	//		var outputBytes =
	//			sha.ComputeHash(buffer: inputBytes);

	//		result =
	//			System.Convert.ToBase64String(inArray: outputBytes);
	//	}

	//	return result;
	//}

	public static string GetSha256(string value)
	{
		var inputBytes = System.Text
			.Encoding.UTF8.GetBytes(s: value);

		//using var sha = System.Security
		//	.Cryptography.SHA256.Create();

		//var outputBytes =
		//	sha.ComputeHash(buffer: inputBytes);

		var outputBytes =
			System.Security.Cryptography
			.SHA256.HashData(source: inputBytes);

		var result =
			System.Convert
			.ToBase64String(inArray: outputBytes);

		return result;
	}

	public static string GetMD5(string value)
	{
		var inputBytes = System.Text
			.Encoding.UTF8.GetBytes(s: value);

		var outputBytes =
			System.Security.Cryptography
			.MD5.HashData(source: inputBytes);

		var result =
			System.Convert
			.ToBase64String(inArray: outputBytes);

		return result;
	}
}
