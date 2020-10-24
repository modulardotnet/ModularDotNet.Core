using System;
using Xunit;

namespace ModularDotNet.Core.Tests
{
    public class StringExtensionTests
    {
        #region Fields

        private const int _TestRandomRound = 10;

        private static Random _Seed = new Random();

        #endregion

        #region Methods

        [Fact]
        public void StringExtension_GenerateRandomString_NoPrefer()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100));
                Assert.Matches(@"^[0-9a-zA-Z]+$", randomValue);
            }
        }

        [Fact]
        public void StringExtension_GenerateRandomString_NumberOnly()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100), true);
                Assert.Matches(@"^[0-9]+$", randomValue);
            }
        }

        [Fact]
        public void StringExtension_GenerateRandomString_LowercaseOnly()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100), lowercase: true);
                Assert.Matches(@"^[a-z]+$", randomValue);
            }
        }

        [Fact]
        public void StringExtension_GenerateRandomString_UppercaseOnly()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100), uppercase: true);
                Assert.Matches(@"^[A-Z]+$", randomValue);
            }
        }

        [Fact]
        public void StringExtension_CheckLuhn()
        {
            Assert.True("79927398713".CheckLuhn());
        }

        [Fact]
        public void StringExtension_Pad()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomLength = new Random(_Seed.Next()).Next(10, 20);
                var randomValue = new Random(_Seed.Next()).Next(10, 100).ToString();
                Assert.Equal(randomValue.Pad(randomLength).Length, randomLength);
            }
        }

        #endregion
    }
}
