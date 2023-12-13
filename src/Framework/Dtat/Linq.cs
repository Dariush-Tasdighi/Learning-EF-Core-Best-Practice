using System.Linq;

namespace Dtat;

/// <summary>
/// https://nwb.one/blog/linq-extensions-pagination-order-by-property-name
/// </summary>
public static class Linq : object
{
	public const string Ascending = "ASC";
	public const string Descending = "DESC";

	static Linq()
	{
	}

	public static System.Linq.IOrderedQueryable<T> Order<T>
		(this System.Linq.IQueryable<T> source, string expression)
	{
		// استفاده از دستور ذیل غلط است
		//expression =
		//	expression.ToLower();

		var expressions =
			expression.Split(separator: ' ');

		if (expressions.Length > 2)
		{
			var errorMessage =
				$"[expression] has more that two parts!";

			throw new System
				.Exception(message: errorMessage);
		}

		string propertyName;

		if (expressions.Length == 1)
		{
			propertyName = expressions[0];

			var result = source.OrderBy(keySelector:
				ToLambda<T>(propertyName: propertyName));

			return result;
		}

		propertyName = expressions[0];

		if (expressions[1].ToUpper() == Ascending)
		{
			var result =
				source.OrderBy(keySelector:
				ToLambda<T>(propertyName: propertyName));

			return result;
		}
		else
		{
			if (expressions[1].ToUpper() == Descending)
			{
				var result =
					source.OrderByDescending
					(keySelector: ToLambda<T>(propertyName: propertyName));

				return result;
			}
			else
			{
				var errorMessage =
					$"the second part of [expression] is not valid!";

				throw new System
					.Exception(message: errorMessage);
			}
		}
	}

	public static System.Linq.IOrderedQueryable<T> OrderBy<T>
		(this System.Linq.IQueryable<T> source, string propertyName)
	{
		var result = source.OrderBy(keySelector:
			ToLambda<T>(propertyName: propertyName));

		return result;
	}

	public static System.Linq.IOrderedQueryable<T> OrderByDescending<T>
		(this System.Linq.IQueryable<T> source, string propertyName)
	{
		var result = source.OrderByDescending(keySelector:
			ToLambda<T>(propertyName: propertyName));

		return result;
	}

	private static System.Linq.Expressions.Expression
		<System.Func<T, object>> ToLambda<T>(string propertyName)
	{
		var parameter =
			System.Linq.Expressions
			.Expression.Parameter(type: typeof(T));

		var property =
			System.Linq.Expressions.Expression
			.Property(expression: parameter, propertyName: propertyName);

		var propAsObject =
			System.Linq.Expressions.Expression
			.Convert(expression: property, type: typeof(object));

		var result =
			System.Linq.Expressions.Expression.Lambda
			<System.Func<T, object>>(body: propAsObject, parameters: parameter);

		return result;
	}
}
