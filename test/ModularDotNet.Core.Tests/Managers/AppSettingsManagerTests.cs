using System.Linq;
using System;
using ModularDotNet.Core.Interfaces;
using ModularDotNet.Core.Managers;
using ModularDotNet.Core.Tests.TestMaterials.Enums;
using ModularDotNet.Core.Tests.TestMaterials.Providers;
using ModularDotNet.Core.Tests.TestUtilities;
using Xunit;

namespace ModularDotNet.Core.Tests.Managers
{
    public class AppSettingsManagerTests
    {
        #region Fields

        private const int _TestRandomRound = 10;

        #endregion

        #region Constructor

        public AppSettingsManagerTests()
        {
            Engine.Register<IAppSettingsProvider, AppSettingsProvider>();
            AppSettingsProvider.EncryptionKeyPair = EncryptionManager.Aes.GenerateKeyPair();
        }

        #endregion

        #region Methods

        [Fact]
        public void AppSettingsManager_Boolean_NoEncryption()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomKey = Generator.RandomString();
                var randomValue = Generator.RandomBoolean();

                Assert.Null(AppSettingsManager.GetBoolean(randomKey));

                AppSettingsManager.SetBoolean(randomKey, randomValue);

                Assert.Equal(randomValue, AppSettingsManager.GetBoolean(randomKey));
            }
        }

        [Fact]
        public void AppSettingsManager_Boolean_GotEncryption()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomKey = Generator.RandomString();
                var randomValue = Generator.RandomBoolean();

                Assert.Null(AppSettingsManager.GetBoolean(randomKey, true));

                AppSettingsManager.SetBoolean(randomKey, randomValue, true);

                Assert.Equal(randomValue, AppSettingsManager.GetBoolean(randomKey, true));
            }
        }

        [Fact]
        public void AppSettingsManager_Boolean_DefaultValue()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomKey = Generator.RandomString();
                var randomValue = Generator.RandomBoolean();

                Assert.Null(AppSettingsManager.GetBoolean(randomKey));

                Assert.Equal(randomValue, AppSettingsManager.GetBoolean(randomKey, randomValue, false));
            }
        }

        [Fact]
        public void AppSettingsManager_Byte_NoEncryption()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomKey = Generator.RandomString();
                var randomValue = Generator.RandomByte();

                Assert.Null(AppSettingsManager.GetByte(randomKey));

                AppSettingsManager.SetByte(randomKey, randomValue);

                Assert.Equal(randomValue, AppSettingsManager.GetByte(randomKey));
            }
        }

        [Fact]
        public void AppSettingsManager_Byte_GotEncryption()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomKey = Generator.RandomString();
                var randomValue = Generator.RandomByte();

                Assert.Null(AppSettingsManager.GetByte(randomKey, true));

                AppSettingsManager.SetByte(randomKey, randomValue, true);

                Assert.Equal(randomValue, AppSettingsManager.GetByte(randomKey, true));
            }
        }

        [Fact]
        public void AppSettingsManager_Byte_DefaultValue()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomKey = Generator.RandomString();
                var randomValue = Generator.RandomByte();

                Assert.Null(AppSettingsManager.GetByte(randomKey));

                Assert.Equal(randomValue, AppSettingsManager.GetByte(randomKey, randomValue, false));
            }
        }

        [Fact]
        public void AppSettingsManager_Bytes_NoEncryption()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomKey = Generator.RandomString();
                var randomValue = Generator.RandomBytes();

                Assert.Null(AppSettingsManager.GetBytes(randomKey));

                AppSettingsManager.SetBytes(randomKey, randomValue);

                Assert.Equal(randomValue, AppSettingsManager.GetBytes(randomKey));
            }
        }

        [Fact]
        public void AppSettingsManager_Bytes_GotEncryption()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomKey = Generator.RandomString();
                var randomValue = Generator.RandomBytes();

                Assert.Null(AppSettingsManager.GetBytes(randomKey, true));

                AppSettingsManager.SetBytes(randomKey, randomValue, true);

                Assert.Equal(randomValue, AppSettingsManager.GetBytes(randomKey, true));
            }
        }

        [Fact]
        public void AppSettingsManager_Bytes_DefaultValue()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomKey = Generator.RandomString();
                var randomValue = Generator.RandomBytes();

                Assert.Null(AppSettingsManager.GetBytes(randomKey));

                Assert.Equal(randomValue, AppSettingsManager.GetBytes(randomKey, randomValue, false));
            }
        }

        [Fact]
        public void AppSettingsManager_DateTime_NoEncryption()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomKey = Generator.RandomString();
                var randomValue = Generator.RandomDateTime();

                Assert.Null(AppSettingsManager.GetDateTime(randomKey));

                AppSettingsManager.SetDateTime(randomKey, randomValue);

                Assert.Equal(randomValue, AppSettingsManager.GetDateTime(randomKey));
            }
        }

        [Fact]
        public void AppSettingsManager_DateTime_GotEncryption()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomKey = Generator.RandomString();
                var randomValue = Generator.RandomDateTime();

                Assert.Null(AppSettingsManager.GetDateTime(randomKey, true));

                AppSettingsManager.SetDateTime(randomKey, randomValue, true);

                Assert.Equal(randomValue, AppSettingsManager.GetDateTime(randomKey, true));
            }
        }

        [Fact]
        public void AppSettingsManager_DateTime_DefaultValue()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomKey = Generator.RandomString();
                var randomValue = Generator.RandomDateTime();

                Assert.Null(AppSettingsManager.GetDateTime(randomKey));

                Assert.Equal(randomValue, AppSettingsManager.GetDateTime(randomKey, randomValue));
            }
        }

        [Fact]
        public void AppSettingsManager_Decimal_NoEncryption()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomKey = Generator.RandomString();
                var randomValue = Generator.RandomDecimal();

                Assert.Null(AppSettingsManager.GetDecimal(randomKey));

                AppSettingsManager.SetDecimal(randomKey, randomValue);

                Assert.Equal(randomValue, AppSettingsManager.GetDecimal(randomKey));
            }
        }

        [Fact]
        public void AppSettingsManager_Decimal_GotEncryption()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomKey = Generator.RandomString();
                var randomValue = Generator.RandomDecimal();

                Assert.Null(AppSettingsManager.GetDecimal(randomKey, true));

                AppSettingsManager.SetDecimal(randomKey, randomValue, true);

                Assert.Equal(randomValue, AppSettingsManager.GetDecimal(randomKey, true));
            }
        }

        [Fact]
        public void AppSettingsManager_Decimal_DefaultValue()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomKey = Generator.RandomString();
                var randomValue = Generator.RandomDecimal();

                Assert.Null(AppSettingsManager.GetDecimal(randomKey));

                Assert.Equal(randomValue, AppSettingsManager.GetDecimal(randomKey, randomValue));
            }
        }

        [Fact]
        public void AppSettingsManager_Double_NoEncryption()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomKey = Generator.RandomString();
                var randomValue = Generator.RandomDouble();

                Assert.Null(AppSettingsManager.GetDouble(randomKey));

                AppSettingsManager.SetDouble(randomKey, randomValue);

                Assert.Equal(randomValue, AppSettingsManager.GetDouble(randomKey));
            }
        }

        [Fact]
        public void AppSettingsManager_Double_GotEncryption()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomKey = Generator.RandomString();
                var randomValue = Generator.RandomDouble();

                Assert.Null(AppSettingsManager.GetDouble(randomKey, true));

                AppSettingsManager.SetDouble(randomKey, randomValue, true);

                Assert.Equal(randomValue, AppSettingsManager.GetDouble(randomKey, true));
            }
        }

        [Fact]
        public void AppSettingsManager_Double_DefaultValue()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomKey = Generator.RandomString();
                var randomValue = Generator.RandomDouble();

                Assert.Null(AppSettingsManager.GetDouble(randomKey));

                Assert.Equal(randomValue, AppSettingsManager.GetDouble(randomKey, randomValue));
            }
        }

        [Fact]
        public void AppSettingsManager_Enum_NoEncryption()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomKey = Generator.RandomString();
                var randomDefaultValue = (EnumGender)Generator.RandomInt(0, Enum.GetValues(typeof(EnumGender)).Length);
                var randomValue = (EnumGender)Generator.RandomInt(0, Enum.GetValues(typeof(EnumGender)).Length);

                Assert.Equal(randomDefaultValue, AppSettingsManager.GetEnum(randomKey, randomDefaultValue));

                AppSettingsManager.SetEnum(randomKey, randomValue);

                Assert.Equal(randomValue, AppSettingsManager.GetEnum(randomKey, randomDefaultValue));
            }
        }

        [Fact]
        public void AppSettingsManager_Enum_GotEncryption()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomKey = Generator.RandomString();
                var randomDefaultValue = (EnumGender)Generator.RandomInt(0, Enum.GetValues(typeof(EnumGender)).Length);
                var randomValue = (EnumGender)Generator.RandomInt(0, Enum.GetValues(typeof(EnumGender)).Length);

                Assert.Equal(randomDefaultValue, AppSettingsManager.GetEnum(randomKey, randomDefaultValue, true));

                AppSettingsManager.SetEnum(randomKey, randomValue, true);

                Assert.Equal(randomValue, AppSettingsManager.GetEnum(randomKey, randomDefaultValue, true));
            }
        }

        [Fact]
        public void AppSettingsManager_Float_NoEncryption()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomKey = Generator.RandomString();
                var randomValue = Generator.RandomFloat();

                Assert.Null(AppSettingsManager.GetFloat(randomKey));

                AppSettingsManager.SetFloat(randomKey, randomValue);

                Assert.Equal(randomValue, AppSettingsManager.GetFloat(randomKey));
            }
        }

        [Fact]
        public void AppSettingsManager_Float_GotEncryption()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomKey = Generator.RandomString();
                var randomValue = Generator.RandomFloat();

                Assert.Null(AppSettingsManager.GetFloat(randomKey, true));

                AppSettingsManager.SetFloat(randomKey, randomValue, true);

                Assert.Equal(randomValue, AppSettingsManager.GetFloat(randomKey, true));
            }
        }

        [Fact]
        public void AppSettingsManager_Float_DefaultValue()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomKey = Generator.RandomString();
                var randomValue = Generator.RandomFloat();

                Assert.Null(AppSettingsManager.GetFloat(randomKey));

                Assert.Equal(randomValue, AppSettingsManager.GetFloat(randomKey, randomValue));
            }
        }

        [Fact]
        public void AppSettingsManager_Int_NoEncryption()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomKey = Generator.RandomString();
                var randomValue = Generator.RandomInt();

                Assert.Null(AppSettingsManager.GetInt(randomKey));

                AppSettingsManager.SetInt(randomKey, randomValue);

                Assert.Equal(randomValue, AppSettingsManager.GetInt(randomKey));
            }
        }

        [Fact]
        public void AppSettingsManager_Int_GotEncryption()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomKey = Generator.RandomString();
                var randomValue = Generator.RandomInt();

                Assert.Null(AppSettingsManager.GetInt(randomKey, true));

                AppSettingsManager.SetInt(randomKey, randomValue, true);

                Assert.Equal(randomValue, AppSettingsManager.GetInt(randomKey, true));
            }
        }

        [Fact]
        public void AppSettingsManager_Int_DefaultValue()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomKey = Generator.RandomString();
                var randomValue = Generator.RandomInt();

                Assert.Null(AppSettingsManager.GetInt(randomKey));

                Assert.Equal(randomValue, AppSettingsManager.GetInt(randomKey, randomValue));
            }
        }

        [Fact]
        public void AppSettingsManager_Long_NoEncryption()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomKey = Generator.RandomString();
                var randomValue = Generator.RandomLong();

                Assert.Null(AppSettingsManager.GetLong(randomKey));

                AppSettingsManager.SetLong(randomKey, randomValue);

                Assert.Equal(randomValue, AppSettingsManager.GetLong(randomKey));
            }
        }

        [Fact]
        public void AppSettingsManager_Long_GotEncryption()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomKey = Generator.RandomString();
                var randomValue = Generator.RandomLong();

                Assert.Null(AppSettingsManager.GetLong(randomKey, true));

                AppSettingsManager.SetLong(randomKey, randomValue, true);

                Assert.Equal(randomValue, AppSettingsManager.GetLong(randomKey, true));
            }
        }

        [Fact]
        public void AppSettingsManager_Long_DefaultValue()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomKey = Generator.RandomString();
                var randomValue = Generator.RandomLong();

                Assert.Null(AppSettingsManager.GetLong(randomKey));

                Assert.Equal(randomValue, AppSettingsManager.GetLong(randomKey, randomValue));
            }
        }

        [Fact]
        public void AppSettingsManager_Short_NoEncryption()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomKey = Generator.RandomString();
                var randomValue = Generator.RandomShort();

                Assert.Null(AppSettingsManager.GetShort(randomKey));

                AppSettingsManager.SetShort(randomKey, randomValue);

                Assert.Equal(randomValue, AppSettingsManager.GetShort(randomKey));
            }
        }

        [Fact]
        public void AppSettingsManager_Short_GotEncryption()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomKey = Generator.RandomString();
                var randomValue = Generator.RandomShort();

                Assert.Null(AppSettingsManager.GetShort(randomKey, true));

                AppSettingsManager.SetShort(randomKey, randomValue, true);

                Assert.Equal(randomValue, AppSettingsManager.GetShort(randomKey, true));
            }
        }

        [Fact]
        public void AppSettingsManager_Short_DefaultValue()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomKey = Generator.RandomString();
                var randomValue = Generator.RandomShort();

                Assert.Null(AppSettingsManager.GetShort(randomKey));

                Assert.Equal(randomValue, AppSettingsManager.GetShort(randomKey, randomValue));
            }
        }

        [Fact]
        public void AppSettingsManager_String_NoEncryption()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomKey = Generator.RandomString();
                var randomValue = Generator.RandomString();

                Assert.Null(AppSettingsManager.GetString(randomKey));

                AppSettingsManager.SetString(randomKey, randomValue);

                Assert.Equal(randomValue, AppSettingsManager.GetString(randomKey));
            }
        }

        [Fact]
        public void AppSettingsManager_String_GotEncryption()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomKey = Generator.RandomString();
                var randomValue = Generator.RandomString();

                Assert.Null(AppSettingsManager.GetString(randomKey, true));

                AppSettingsManager.SetString(randomKey, randomValue, true);

                Assert.Equal(randomValue, AppSettingsManager.GetString(randomKey, true));
            }
        }

        [Fact]
        public void AppSettingsManager_String_DefaultValue()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomKey = Generator.RandomString();
                var randomValue = Generator.RandomString();

                Assert.Null(AppSettingsManager.GetString(randomKey));

                Assert.Equal(randomValue, AppSettingsManager.GetString(randomKey, randomValue));
            }
        }

        #endregion
    }
}
