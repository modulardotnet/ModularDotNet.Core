using System;
using ModularDotNet.Core.Tests.TestMaterials.Enums;
using Xunit;

namespace ModularDotNet.Core.Tests.Helpers
{
    public class EnumHelperTests
    {
        #region Methods

        [Fact]
        public void EnumHelper_GetDictionary()
        {
            var dic = EnumHelper.GetDictionary<EnumGender>();

            foreach (var each in Enum.GetValues(typeof(EnumGender)))
            {
                Assert.True(dic.ContainsKey((int)each) && each.ToString().Equals(dic[(int)each]));
            }
        }

        [Fact]
        public void EnumHelper_GetDictionary_WithStructButNonEnum()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var dic = EnumHelper.GetDictionary<int>();
            });
        }

        [Fact]
        public void EnumHelper_GetDictionary_WithIgnore()
        {
            var dic = EnumHelper.GetDictionary<EnumGender>(EnumGender.Male);

            foreach (var each in Enum.GetValues(typeof(EnumGender)))
            {
                if ((EnumGender)each == EnumGender.Male)
                {
                    continue;
                }

                Assert.True(dic.ContainsKey((int)each) && each.ToString().Equals(dic[(int)each]));
            }
        }

        [Fact]
        public void EnumHelper_GetDictionary_WithIgnoreWithStructButNonEnum()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var dic = EnumHelper.GetDictionary<int>(1);
            });
        }

        [Fact]
        public void EnumHelper_GetDictionaryInDescription()
        {
            var dic = EnumHelper.GetDictionaryInDescription<EnumGender>();

            foreach (var each in Enum.GetValues(typeof(EnumGender)))
            {
                Assert.True(dic.ContainsKey((int)each) && ((Enum)each).GetDescription().Equals(dic[(int)each]));
            }
        }

        [Fact]
        public void EnumHelper_GetDictionaryInDescription_WithStructButNonEnum()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var dic = EnumHelper.GetDictionaryInDescription<int>();
            });
        }

        [Fact]
        public void EnumHelper_GetDictionaryInDescription_WithIgnore()
        {
            var dic = EnumHelper.GetDictionaryInDescription<EnumGender>(EnumGender.Male);

            foreach (var each in Enum.GetValues(typeof(EnumGender)))
            {
                if ((EnumGender)each == EnumGender.Male)
                {
                    continue;
                }

                Assert.True(dic.ContainsKey((int)each) && ((Enum)each).GetDescription().Equals(dic[(int)each]));
            }
        }

        [Fact]
        public void EnumHelper_GetDictionaryInDescription_WithIgnoreWithStructButNonEnum()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var dic = EnumHelper.GetDictionaryInDescription<int>(1);
            });
        }

        [Fact]
        public void EnumHelper_GetDictionaryInDisplayText()
        {
            var dic = EnumHelper.GetDictionaryInDisplayText<EnumGender>();

            foreach (var each in Enum.GetValues(typeof(EnumGender)))
            {
                Assert.True(dic.ContainsKey((int)each) && ((Enum)each).GetDisplayText().Equals(dic[(int)each]));
            }
        }

        [Fact]
        public void EnumHelper_GetDictionaryInDisplayText_WithStructButNonEnum()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var dic = EnumHelper.GetDictionaryInDisplayText<int>();
            });
        }

        [Fact]
        public void EnumHelper_GetDictionaryInDisplayText_WithIgnore()
        {
            var dic = EnumHelper.GetDictionaryInDisplayText<EnumGender>(EnumGender.Male);

            foreach (var each in Enum.GetValues(typeof(EnumGender)))
            {
                if ((EnumGender)each == EnumGender.Male)
                {
                    continue;
                }

                Assert.True(dic.ContainsKey((int)each) && ((Enum)each).GetDisplayText().Equals(dic[(int)each]));
            }
        }

        [Fact]
        public void EnumHelper_GetDictionaryInDisplayText_WithIgnoreWithStructButNonEnum()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var dic = EnumHelper.GetDictionaryInDisplayText<int>(1);
            });
        }

        #endregion
    }
}
