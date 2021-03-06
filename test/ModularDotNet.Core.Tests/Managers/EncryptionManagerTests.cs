using System;
using DryIoc;
using Xunit;
using ModularDotNet.Core.Managers;
using ModularDotNet.Core.Tests.TestUtilities;
using ModularDotNet.Core.Tests.TestMaterials.Interfaces;
using ModularDotNet.Core.Interfaces;

namespace ModularDotNet.Core.Tests.Managers
{
    [TestCaseOrderer("ModularDotNet.Core.Tests.TestUtilities.TestPriorityOrderer", "ModularDotNet.Core.Tests")]
    public class EncryptionManagerTests
    {
        #region Fields

        private const int _TestRandomRound = 10;

        #endregion

        #region Methods

        [Fact]
        public void EncryptionManager_EncyrptWithEmptyInput()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                var keyPair = EncryptionManager.Aes.GenerateKeyPair();
                EncryptionManager.Aes.Encrypt(null, keyPair);
            });
        }

        [Fact]
        public void EncryptionManager_EncyrptWithEmptyKeyPair()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                var randomValue = Generator.RandomString();
                EncryptionManager.Aes.Encrypt(randomValue);
            });
            Assert.Throws<ArgumentNullException>(() =>
            {
                var randomValue = Generator.RandomString();
                EncryptionManager.Aes.Encrypt(randomValue, Generator.RandomBytes(), null);
            });
            Assert.Throws<ArgumentNullException>(() =>
            {
                var randomValue = Generator.RandomString();
                EncryptionManager.Aes.Encrypt(randomValue, null, Generator.RandomBytes());
            });
        }

        [Fact]
        public void EncryptionManager_DecyrptWithEmptyInput()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                var keyPair = EncryptionManager.Aes.GenerateKeyPair();
                EncryptionManager.Aes.Decrypt(null, keyPair);
            });
        }

        [Fact]
        public void EncryptionManager_DecyrptWithEmptyKeyPair()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                var base64 = Convert.ToBase64String(Generator.RandomBytes());
                EncryptionManager.Aes.Decrypt(base64);
            });
            Assert.Throws<ArgumentNullException>(() =>
            {
                var base64 = Convert.ToBase64String(Generator.RandomBytes());
                EncryptionManager.Aes.Decrypt(base64, Generator.RandomBytes(), null);
            });
            Assert.Throws<ArgumentNullException>(() =>
            {
                var base64 = Convert.ToBase64String(Generator.RandomBytes());
                EncryptionManager.Aes.Decrypt(base64, null, Generator.RandomBytes());
            });
        }

        [Fact, TestPriority(100)]
        public void EncryptionManager_EncyrptionWithCurrent()
        {
            Engine.Register<ICurrent, Current>(Reuse.ScopedOrSingleton);

            var randomValue = Generator.RandomString();

            var encrypted = EncryptionManager.Aes.Encrypt(randomValue);
            var decrypted = EncryptionManager.Aes.Decrypt(encrypted);

            Assert.Equal(randomValue, decrypted);
        }

        [Fact]
        public void EncryptionManager_Aes_NormalEncryption()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomValue = Generator.RandomString();
                var keyPair = EncryptionManager.Aes.GenerateKeyPair();

                var encrypted = EncryptionManager.Aes.Encrypt(randomValue, keyPair);
                var decrypted = EncryptionManager.Aes.Decrypt(encrypted, keyPair);

                Assert.Equal(randomValue, decrypted);
            }
        }

        [Fact]
        public void EncryptionManager_Aes_NormalEncryption_Int()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomValue = Generator.RandomInt();
                var keyPair = EncryptionManager.Aes.GenerateKeyPair();

                var encrypted = EncryptionManager.Aes.Encrypt(randomValue.ToString(), keyPair);
                var decrypted = EncryptionManager.Aes.Decrypt<int>(encrypted, keyPair);

                Assert.Equal(randomValue, decrypted);
            }
        }

        [Fact]
        public void EncryptionManager_Aes_NormalEncryption_NullableInt()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomValue = Generator.RandomInt();
                var keyPair = EncryptionManager.Aes.GenerateKeyPair();

                var encrypted = EncryptionManager.Aes.Encrypt(randomValue.ToString(), keyPair);
                var decrypted = EncryptionManager.Aes.Decrypt<int?>(encrypted, keyPair);

                Assert.Equal(randomValue, decrypted);
            }
        }

        [Fact]
        public void EncryptionManager_Aes_NormalEncryption_Double()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomValue = Generator.RandomDouble();
                var keyPair = EncryptionManager.Aes.GenerateKeyPair();

                var encrypted = EncryptionManager.Aes.Encrypt(randomValue.ToString(), keyPair);
                var decrypted = EncryptionManager.Aes.Decrypt<double>(encrypted, keyPair);

                Assert.Equal(randomValue, decrypted);
            }
        }

        [Fact]
        public void EncryptionManager_Aes_NormalEncryption_NullableDouble()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomValue = Generator.RandomDouble();
                var keyPair = EncryptionManager.Aes.GenerateKeyPair();

                var encrypted = EncryptionManager.Aes.Encrypt(randomValue.ToString(), keyPair);
                var decrypted = EncryptionManager.Aes.Decrypt<double?>(encrypted, keyPair);

                Assert.Equal(randomValue, decrypted);
            }
        }

        [Fact]
        public void EncryptionManager_Aes_NormalEncryption_Decimal()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomValue = Generator.RandomDecimal();
                var keyPair = EncryptionManager.Aes.GenerateKeyPair();

                var encrypted = EncryptionManager.Aes.Encrypt(randomValue.ToString(), keyPair);
                var decrypted = EncryptionManager.Aes.Decrypt<decimal>(encrypted, keyPair);

                Assert.Equal(randomValue, decrypted);
            }
        }

        [Fact]
        public void EncryptionManager_Aes_NormalEncryption_NullableDecimal()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomValue = Generator.RandomDecimal();
                var keyPair = EncryptionManager.Aes.GenerateKeyPair();

                var encrypted = EncryptionManager.Aes.Encrypt(randomValue.ToString(), keyPair);
                var decrypted = EncryptionManager.Aes.Decrypt<decimal?>(encrypted, keyPair);

                Assert.Equal(randomValue, decrypted);
            }
        }

        [Fact]
        public void EncryptionManager_Aes_NormalEncryption_Boolean()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomValue = Generator.RandomBoolean();
                var keyPair = EncryptionManager.Aes.GenerateKeyPair();

                var encrypted = EncryptionManager.Aes.Encrypt(randomValue.ToString(), keyPair);
                var decrypted = EncryptionManager.Aes.Decrypt<bool>(encrypted, keyPair);

                Assert.Equal(randomValue, decrypted);
            }
        }

        [Fact]
        public void EncryptionManager_Aes_NormalEncryption_NullableBoolean()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomValue = Generator.RandomBoolean();
                var keyPair = EncryptionManager.Aes.GenerateKeyPair();

                var encrypted = EncryptionManager.Aes.Encrypt(randomValue.ToString(), keyPair);
                var decrypted = EncryptionManager.Aes.Decrypt<bool?>(encrypted, keyPair);

                Assert.Equal(randomValue, decrypted);
            }
        }

        [Fact]
        public void EncryptionManager_Aes_UrlEncryption()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomValue = Generator.RandomString();
                var keyPair = EncryptionManager.Aes.GenerateKeyPair();

                var encrypted = EncryptionManager.Aes.UrlEncrypt(randomValue, keyPair);
                var decrypted = EncryptionManager.Aes.UrlDecrypt(encrypted, keyPair);

                Assert.Equal(randomValue, decrypted);
            }
        }

        [Fact]
        public void EncryptionManager_Aes_UrlEncryption_Int()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomValue = Generator.RandomInt();
                var keyPair = EncryptionManager.Aes.GenerateKeyPair();

                var encrypted = EncryptionManager.Aes.UrlEncrypt(randomValue.ToString(), keyPair);
                var decrypted = EncryptionManager.Aes.UrlDecrypt<int>(encrypted, keyPair);

                Assert.Equal(randomValue, decrypted);
            }
        }

        [Fact]
        public void EncryptionManager_Aes_UrlEncryption_NullableInt()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomValue = Generator.RandomInt();
                var keyPair = EncryptionManager.Aes.GenerateKeyPair();

                var encrypted = EncryptionManager.Aes.UrlEncrypt(randomValue.ToString(), keyPair);
                var decrypted = EncryptionManager.Aes.UrlDecrypt<int?>(encrypted, keyPair);

                Assert.Equal(randomValue, decrypted);
            }
        }

        [Fact]
        public void EncryptionManager_Aes_UrlEncryption_Double()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomValue = Generator.RandomDouble();
                var keyPair = EncryptionManager.Aes.GenerateKeyPair();

                var encrypted = EncryptionManager.Aes.UrlEncrypt(randomValue.ToString(), keyPair);
                var decrypted = EncryptionManager.Aes.UrlDecrypt<double>(encrypted, keyPair);

                Assert.Equal(randomValue, decrypted);
            }
        }

        [Fact]
        public void EncryptionManager_Aes_UrlEncryption_NullableDouble()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomValue = Generator.RandomDouble();
                var keyPair = EncryptionManager.Aes.GenerateKeyPair();

                var encrypted = EncryptionManager.Aes.UrlEncrypt(randomValue.ToString(), keyPair);
                var decrypted = EncryptionManager.Aes.UrlDecrypt<double?>(encrypted, keyPair);

                Assert.Equal(randomValue, decrypted);
            }
        }

        [Fact]
        public void EncryptionManager_Aes_UrlEncryption_Decimal()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomValue = Generator.RandomDecimal();
                var keyPair = EncryptionManager.Aes.GenerateKeyPair();

                var encrypted = EncryptionManager.Aes.UrlEncrypt(randomValue.ToString(), keyPair);
                var decrypted = EncryptionManager.Aes.UrlDecrypt<decimal>(encrypted, keyPair);

                Assert.Equal(randomValue, decrypted);
            }
        }

        [Fact]
        public void EncryptionManager_Aes_UrlEncryption_NullableDecimal()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomValue = Generator.RandomDecimal();
                var keyPair = EncryptionManager.Aes.GenerateKeyPair();

                var encrypted = EncryptionManager.Aes.UrlEncrypt(randomValue.ToString(), keyPair);
                var decrypted = EncryptionManager.Aes.UrlDecrypt<decimal?>(encrypted, keyPair);

                Assert.Equal(randomValue, decrypted);
            }
        }

        [Fact]
        public void EncryptionManager_Aes_UrlEncryption_Boolean()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomValue = Generator.RandomBoolean();
                var keyPair = EncryptionManager.Aes.GenerateKeyPair();

                var encrypted = EncryptionManager.Aes.UrlEncrypt(randomValue.ToString(), keyPair);
                var decrypted = EncryptionManager.Aes.UrlDecrypt<bool>(encrypted, keyPair);

                Assert.Equal(randomValue, decrypted);
            }
        }

        [Fact]
        public void EncryptionManager_Aes_UrlEncryption_NullableBoolean()
        {
            for (var i = 0; i < _TestRandomRound; i++)
            {
                var randomValue = Generator.RandomBoolean();
                var keyPair = EncryptionManager.Aes.GenerateKeyPair();

                var encrypted = EncryptionManager.Aes.UrlEncrypt(randomValue.ToString(), keyPair);
                var decrypted = EncryptionManager.Aes.UrlDecrypt<bool?>(encrypted, keyPair);

                Assert.Equal(randomValue, decrypted);
            }
        }

        #endregion
    }
}
