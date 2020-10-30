
using System;
using System.ComponentModel;
using ModularDotNet.Core.Attributes;

public static class EnumExtension //NOSONAR
{
    #region Methods

    public static string GetDescription(this Enum enumValue)
    {
        var type = enumValue.GetType();
        var memberInfo = type.GetMember(enumValue.ToString());
        if (memberInfo.Length > 0)
        {
            var attributes = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
            {
                return ((DescriptionAttribute)attributes[0]).Description;
            }
        }

        return enumValue.ToString();
    }

    public static string GetDisplayText(this Enum enumValue)
    {
        var type = enumValue.GetType();
        var memberInfo = type.GetMember(enumValue.ToString());
        if (memberInfo.Length > 0)
        {
            var attributes = memberInfo[0].GetCustomAttributes(typeof(DisplayTextAttribute), false);

            if (attributes.Length > 0)
            {
                return ((DisplayTextAttribute)attributes[0]).DisplayText;
            }
        }

        return enumValue.ToString();
    }

    #endregion
}
