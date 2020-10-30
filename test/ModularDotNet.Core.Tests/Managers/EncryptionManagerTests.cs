using System;
using Xunit;
using ModularDotNet.Core.Managers;
using ModularDotNet.Core.Tests.TestUtilities;

namespace ModularDotNet.Core.Tests.Managers
{
    public class EncryptionManagerTests
    {
        #region Methods

        [Fact]
        public void EncryptionManager_Aes_NormalEncryption()
        {
            var randomValue = Generator.RandomString();
            var keyPair = EncryptionManager.Aes.GenerateKeyPair();

            var encrypted = EncryptionManager.Aes.Encrypt(randomValue, keyPair);
            var decrypted = EncryptionManager.Aes.Decrypt(encrypted, keyPair);

            Assert.Equal(randomValue, decrypted);
        }

        [Fact]
        public void EncryptionManager_Aes_NormalEncryption_Int()
        {
            var randomValue = Generator.RandomInt();
            var keyPair = EncryptionManager.Aes.GenerateKeyPair();

            var encrypted = EncryptionManager.Aes.Encrypt(randomValue.ToString(), keyPair);
            var decrypted = EncryptionManager.Aes.Decrypt<int>(encrypted, keyPair);

            Assert.Equal(randomValue, decrypted);
        }

        [Fact]
        public void EncryptionManager_Aes_NormalEncryption_NullableInt()
        {
            var randomValue = Generator.RandomInt();
            var keyPair = EncryptionManager.Aes.GenerateKeyPair();

            var encrypted = EncryptionManager.Aes.Encrypt(randomValue.ToString(), keyPair);
            var decrypted = EncryptionManager.Aes.Decrypt<int?>(encrypted, keyPair);

            Assert.Equal(randomValue, decrypted);
        }

        [Fact]
        public void EncryptionManager_Aes_NormalEncryption_Double()
        {
            var randomValue = Generator.RandomDouble();
            var keyPair = EncryptionManager.Aes.GenerateKeyPair();

            var encrypted = EncryptionManager.Aes.Encrypt(randomValue.ToString(), keyPair);
            var decrypted = EncryptionManager.Aes.Decrypt<double>(encrypted, keyPair);

            Assert.Equal(randomValue, decrypted);
        }

        [Fact]
        public void EncryptionManager_Aes_NormalEncryption_NullableDouble()
        {
            var randomValue = Generator.RandomDouble();
            var keyPair = EncryptionManager.Aes.GenerateKeyPair();

            var encrypted = EncryptionManager.Aes.Encrypt(randomValue.ToString(), keyPair);
            var decrypted = EncryptionManager.Aes.Decrypt<double?>(encrypted, keyPair);

            Assert.Equal(randomValue, decrypted);
        }

        [Fact]
        public void EncryptionManager_Aes_NormalEncryption_Decimal()
        {
            var randomValue = Generator.RandomDecimal();
            var keyPair = EncryptionManager.Aes.GenerateKeyPair();

            var encrypted = EncryptionManager.Aes.Encrypt(randomValue.ToString(), keyPair);
            var decrypted = EncryptionManager.Aes.Decrypt<decimal>(encrypted, keyPair);

            Assert.Equal(randomValue, decrypted);
        }

        [Fact]
        public void EncryptionManager_Aes_NormalEncryption_NullableDecimal()
        {
            var randomValue = Generator.RandomDecimal();
            var keyPair = EncryptionManager.Aes.GenerateKeyPair();

            var encrypted = EncryptionManager.Aes.Encrypt(randomValue.ToString(), keyPair);
            var decrypted = EncryptionManager.Aes.Decrypt<decimal?>(encrypted, keyPair);

            Assert.Equal(randomValue, decrypted);
        }

        [Fact]
        public void EncryptionManager_Aes_NormalEncryption_Boolean()
        {
            var randomValue = Generator.RandomBoolean();
            var keyPair = EncryptionManager.Aes.GenerateKeyPair();

            var encrypted = EncryptionManager.Aes.Encrypt(randomValue.ToString(), keyPair);
            var decrypted = EncryptionManager.Aes.Decrypt<bool>(encrypted, keyPair);

            Assert.Equal(randomValue, decrypted);
        }

        [Fact]
        public void EncryptionManager_Aes_NormalEncryption_NullableBoolean()
        {
            var randomValue = Generator.RandomBoolean();
            var keyPair = EncryptionManager.Aes.GenerateKeyPair();

            var encrypted = EncryptionManager.Aes.Encrypt(randomValue.ToString(), keyPair);
            var decrypted = EncryptionManager.Aes.Decrypt<bool?>(encrypted, keyPair);

            Assert.Equal(randomValue, decrypted);
        }

        [Fact]
        public void EncryptionManager_Aes_UrlEncryption()
        {
            var randomValue = Generator.RandomString();
            var keyPair = EncryptionManager.Aes.GenerateKeyPair();

            var encrypted = EncryptionManager.Aes.UrlEncrypt(randomValue, keyPair);
            var decrypted = EncryptionManager.Aes.UrlDecrypt(encrypted, keyPair);

            Assert.Equal(randomValue, decrypted);
        }

        [Fact]
        public void EncryptionManager_Aes_UrlEncryption_Int()
        {
            var randomValue = Generator.RandomInt();
            var keyPair = EncryptionManager.Aes.GenerateKeyPair();

            var encrypted = EncryptionManager.Aes.UrlEncrypt(randomValue.ToString(), keyPair);
            var decrypted = EncryptionManager.Aes.UrlDecrypt<int>(encrypted, keyPair);

            Assert.Equal(randomValue, decrypted);
        }

        [Fact]
        public void EncryptionManager_Aes_UrlEncryption_NullableInt()
        {
            var randomValue = Generator.RandomInt();
            var keyPair = EncryptionManager.Aes.GenerateKeyPair();

            var encrypted = EncryptionManager.Aes.UrlEncrypt(randomValue.ToString(), keyPair);
            var decrypted = EncryptionManager.Aes.UrlDecrypt<int?>(encrypted, keyPair);

            Assert.Equal(randomValue, decrypted);
        }

        [Fact]
        public void EncryptionManager_Aes_UrlEncryption_Double()
        {
            var randomValue = Generator.RandomDouble();
            var keyPair = EncryptionManager.Aes.GenerateKeyPair();

            var encrypted = EncryptionManager.Aes.UrlEncrypt(randomValue.ToString(), keyPair);
            var decrypted = EncryptionManager.Aes.UrlDecrypt<double>(encrypted, keyPair);

            Assert.Equal(randomValue, decrypted);
        }

        [Fact]
        public void EncryptionManager_Aes_UrlEncryption_NullableDouble()
        {
            var randomValue = Generator.RandomDouble();
            var keyPair = EncryptionManager.Aes.GenerateKeyPair();

            var encrypted = EncryptionManager.Aes.UrlEncrypt(randomValue.ToString(), keyPair);
            var decrypted = EncryptionManager.Aes.UrlDecrypt<double?>(encrypted, keyPair);

            Assert.Equal(randomValue, decrypted);
        }

        [Fact]
        public void EncryptionManager_Aes_UrlEncryption_Decimal()
        {
            var randomValue = Generator.RandomDecimal();
            var keyPair = EncryptionManager.Aes.GenerateKeyPair();

            var encrypted = EncryptionManager.Aes.UrlEncrypt(randomValue.ToString(), keyPair);
            var decrypted = EncryptionManager.Aes.UrlDecrypt<decimal>(encrypted, keyPair);

            Assert.Equal(randomValue, decrypted);
        }

        [Fact]
        public void EncryptionManager_Aes_UrlEncryption_NullableDecimal()
        {
            var randomValue = Generator.RandomDecimal();
            var keyPair = EncryptionManager.Aes.GenerateKeyPair();

            var encrypted = EncryptionManager.Aes.UrlEncrypt(randomValue.ToString(), keyPair);
            var decrypted = EncryptionManager.Aes.UrlDecrypt<decimal?>(encrypted, keyPair);

            Assert.Equal(randomValue, decrypted);
        }

        [Fact]
        public void EncryptionManager_Aes_UrlEncryption_Boolean()
        {
            var randomValue = Generator.RandomBoolean();
            var keyPair = EncryptionManager.Aes.GenerateKeyPair();

            var encrypted = EncryptionManager.Aes.UrlEncrypt(randomValue.ToString(), keyPair);
            var decrypted = EncryptionManager.Aes.UrlDecrypt<bool>(encrypted, keyPair);

            Assert.Equal(randomValue, decrypted);
        }

        [Fact]
        public void EncryptionManager_Aes_UrlEncryption_NullableBoolean()
        {
            var randomValue = Generator.RandomBoolean();
            var keyPair = EncryptionManager.Aes.GenerateKeyPair();

            var encrypted = EncryptionManager.Aes.UrlEncrypt(randomValue.ToString(), keyPair);
            var decrypted = EncryptionManager.Aes.UrlDecrypt<bool?>(encrypted, keyPair);

            Assert.Equal(randomValue, decrypted);
        }

        #endregion
    }
}
