using System;
using System.Text.RegularExpressions;
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
                Assert.True(Regex.IsMatch(randomValue, @"^[0-9a-zA-Z]+$"));
            }
        }

        [Fact]
        public void StringExtension_GenerateRandomString_NumberOnly()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100), true);
                Assert.True(Regex.IsMatch(randomValue, @"^[0-9]+$"));
            }
        }

        [Fact]
        public void StringExtension_GenerateRandomString_LowercaseOnly()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100), lowercase: true);
                Assert.True(Regex.IsMatch(randomValue, @"^[a-z]+$"));
            }
        }

        [Fact]
        public void StringExtension_GenerateRandomString_UppercaseOnly()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100), uppercase: true);
                Assert.True(Regex.IsMatch(randomValue, @"^[A-Z]+$"));
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