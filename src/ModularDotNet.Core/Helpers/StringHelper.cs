public static class StringHelper //NOSONAR
{
    #region Method

    public static string GenerateRandomString(int length, bool numeric = false, bool lowercase = false, bool uppercase = false, bool space = false, bool underscore = false, bool hypen = false, bool period = false)
    {
        return "".GenerateRandomString(length, numeric, lowercase, uppercase, space, underscore, hypen, period);
    }

    #endregion
}
