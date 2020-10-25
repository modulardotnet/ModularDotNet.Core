using System;

namespace ModularDotNet.Core.Tests.TestUtilities
{
    public static class Generator
    {
        #region Properties

        private static Random _Seed = new Random();

        private static Random _Random = new Random(_Seed.Next());

        #endregion

        #region Methods

        public static string RandomString()
        {
            return StringHelper.GenerateRandomString(_Random.Next(10, 100));
        }

        public static int RandomInt(int min = 10, int max = 1000)
        {
            return _Random.Next(min, max);
        }

        public static double RandomDouble()
        {
            return _Random.NextDouble();
        }

        public static decimal RandomDecimal()
        {
            return Convert.ToDecimal(_Random.NextDouble());
        }

        public static bool RandomBoolean()
        {
            return _Random.Next(10, 100) % 2 == 0;
        }

        #endregion
    }
}
