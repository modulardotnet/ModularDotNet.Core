using System;
using System.Linq;

public static class StringExtension
{
    #region Fields

    private static readonly Random _Seed = new Random();

    #endregion

    #region Methods

    public static string GenerateRandomString(this string stringValue, int length, bool numeric = false, bool lowercase = false, bool uppercase = false, bool space = false, bool underscore = false, bool hypen = false, bool period = false)
    {
        var ret = "";
        var validCharacters = "";

        if (lowercase)
        {
            validCharacters += "abcdefghijklmnopqrstuvwxyz";
        }

        if (uppercase)
        {
            validCharacters += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        }

        if (numeric)
        {
            validCharacters += "0123456789";
        }

        if (space)
        {
            validCharacters += " ";
        }

        if (underscore)
        {
            validCharacters += "_";
        }

        if (hypen)
        {
            validCharacters += "-";
        }

        if (period)
        {
            validCharacters += ".";
        }

        if (string.IsNullOrEmpty(validCharacters))
        {
            validCharacters += "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        }

        var rand = new Random(_Seed.Next());

        for (var i = 0; i < length; i++)
        {
            ret += validCharacters[rand.Next(0, validCharacters.Length - 1)];
        }

        return ret;
    }

    public static bool CheckLuhn(this string value)
    {
        if (string.IsNullOrEmpty(value) || value.Length < 2)
            return false;

        if (!value.All(char.IsDigit))
            return false;

        var reverse = value.Select(x => Convert.ToInt32(x) - 48)
            .Reverse()
            .ToList();
        var counter = 0;

        for (var i = 1; i < reverse.Count(); i++)
        {
            if (i % 2 == 0)
            {
                counter += reverse[i];
            }
            else
            {
                var x2 = reverse[i] * 2;
                while (x2.ToString().Length != 1)
                {
                    x2 = x2.ToString()
                        .Select(x => Convert.ToInt32(x) - 48)
                        .Sum();
                }

                counter += x2;
            }
        }

        var checkDigit = 10 - (counter % 10);

        return reverse[0] == checkDigit;
    }

    public static string Pad(this string stringValue, int length, char paddingChar = ' ', bool paddingLeft = true)
    {
        var ret = stringValue;

        if (string.IsNullOrEmpty(ret))
        {
            ret = "";
        }

        if (ret.Length > length)
        {
            ret = paddingLeft
                ? ret.Substring(0, length)
                : ret.Substring(ret.Length - (length + 1), length);
        }
        else if (ret.Length < length)
        {
            ret = paddingLeft
                ? ret.PadLeft(length, paddingChar)
                : ret.PadRight(length, paddingChar);
        }

        return ret;
    }
    
    #endregion
}
