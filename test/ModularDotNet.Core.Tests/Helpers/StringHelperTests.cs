using System;
using Xunit;

namespace ModularDotNet.Core.Tests.Helpers
{
    public class StringHelperTests
    {
        #region Fields

        private const int _TestRandomRound = 10;

        private static Random _Seed = new Random();

        #endregion

        #region Methods

        [Fact]
        public void StringHelper_GenerateRandomString_NoPrefer()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomValue = StringHelper.GenerateRandomString(new Random(_Seed.Next()).Next(10, 100));
                Assert.Matches(@"^[0-9a-zA-Z_\s\-\.]+$", randomValue);
            }
        }

        [Fact]
        public void StringHelper_GenerateRandomString_NumberOnly()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomValue = StringHelper.GenerateRandomString(new Random(_Seed.Next()).Next(10, 100), true);
                Assert.Matches(@"^[0-9]+$", randomValue);
            }
        }

        [Fact]
        public void StringHelper_GenerateRandomString_LowercaseOnly()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomValue = StringHelper.GenerateRandomString(new Random(_Seed.Next()).Next(10, 100), lowercase: true);
                Assert.Matches(@"^[a-z]+$", randomValue);
            }
        }

        [Fact]
        public void StringHelper_GenerateRandomString_UppercaseOnly()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomValue = StringHelper.GenerateRandomString(new Random(_Seed.Next()).Next(10, 100), uppercase: true);
                Assert.Matches(@"^[A-Z]+$", randomValue);
            }
        }

        #endregion
    }
}
