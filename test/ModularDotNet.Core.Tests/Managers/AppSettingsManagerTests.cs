using System;
using ModularDotNet.Core.Interfaces;
using ModularDotNet.Core.Managers;
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
        public void AppSettingsManager_NoEncryption()
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
        public void AppSettingsManager_GotEncryption()
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

        #endregion
    }
}
