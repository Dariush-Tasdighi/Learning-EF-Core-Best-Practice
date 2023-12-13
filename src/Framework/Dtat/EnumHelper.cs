using System.Linq;
using System.Reflection;

namespace Dtat;

public static class EnumHelper : object
{
	static EnumHelper()
	{
	}

	public static string? GetDisplayName(this System.Enum? enumValue)
	{
		if (enumValue is null)
		{
			return null;
		}

		var currentType =
			enumValue.GetType();

		if (currentType is null)
		{
			return enumValue.ToString();
		}

		var membersInfo =
			currentType.GetMember(name: enumValue.ToString())
			.FirstOrDefault();

		if (membersInfo is null)
		{
			return enumValue.ToString();
		}

		var displayAttribute =
			// using System.Reflection;
			membersInfo.GetCustomAttribute
			<System.ComponentModel.DataAnnotations.DisplayAttribute>();

		if (displayAttribute is null)
		{
			return enumValue.ToString();
		}

		var name =
			displayAttribute.Name;

		if (name is null)
		{
			return enumValue.ToString();
		}

		if (displayAttribute.ResourceType is null)
		{
			return name;
		}

		var resourceType =
			displayAttribute.ResourceType;

		var resourceManager = new System.Resources
			.ResourceManager(resourceSource: resourceType);

		var value =
			resourceManager.GetString(name: name);

		if (value is null)
		{
			return name;
		}

		return value;
	}
}
