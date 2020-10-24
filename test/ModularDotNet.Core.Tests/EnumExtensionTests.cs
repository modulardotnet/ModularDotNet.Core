using ModularDotNet.Core.Tests.Enums;
using Xunit;

namespace ModularDotNet.Core.Tests
{
    public class EnumExtensionTests
    {
        #region Methods

        [Fact]
        public void EnumExtension_GetDescription_NoImplement()
        {
            Assert.Equal("Male", EnumGender.Male.GetDescription());
        }

        [Fact]
        public void EnumExtension_GetDescription_ImplementAttribute()
        {
            Assert.Equal("", EnumGender.NotSpecific.GetDescription());
        }

        [Fact]
        public void EnumExtension_GetDisplayText_NoImplement()
        {
            Assert.Equal("Male", EnumGender.Male.GetDisplayText());
        }

        [Fact]
        public void EnumExtension_GetDisplayText_ImplementAttribute()
        {
            Assert.Equal("female", EnumGender.Female.GetDisplayText());
        }

        #endregion
    }
}
