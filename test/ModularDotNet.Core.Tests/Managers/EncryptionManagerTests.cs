using System;
using Xunit;
using ModularDotNet.Core.Managers;

namespace ModularDotNet.Core.Tests.Managers
{
    public class EncryptionManagerTests
    {
        #region Fields

        private static Random _Seed = new Random();

        #endregion

        #region Methods

        [Fact]
        public void EncryptionManager_Aes_NormalEncryption()
        {
            var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100));
            var keyPair = EncryptionManager.Aes.GenerateKeyPair();

            var encrypted = EncryptionManager.Aes.Encrypt(randomValue, keyPair);
            var decrypted = EncryptionManager.Aes.Decrypt(encrypted, keyPair);

            Assert.Equal(randomValue, decrypted);
        }

        [Fact]
        public void EncryptionManager_Aes_NormalEncryption_Int()
        {
            var randomValue = new Random(_Seed.Next()).Next(10, 100);
            var keyPair = EncryptionManager.Aes.GenerateKeyPair();

            var encrypted = EncryptionManager.Aes.Encrypt(randomValue.ToString(), keyPair);
            var decrypted = EncryptionManager.Aes.Decrypt<int>(encrypted, keyPair);

            Assert.Equal(randomValue, decrypted);
        }

        [Fact]
        public void EncryptionManager_Aes_NormalEncryption_Double()
        {
            var randomValue = new Random(_Seed.Next()).NextDouble();
            var keyPair = EncryptionManager.Aes.GenerateKeyPair();

            var encrypted = EncryptionManager.Aes.Encrypt(randomValue.ToString(), keyPair);
            var decrypted = EncryptionManager.Aes.Decrypt<double>(encrypted, keyPair);

            Assert.Equal(randomValue, decrypted);
        }

        [Fact]
        public void EncryptionManager_Aes_NormalEncryption_Decimal()
        {
            var randomValue = Convert.ToDecimal(new Random(_Seed.Next()).NextDouble());
            var keyPair = EncryptionManager.Aes.GenerateKeyPair();

            var encrypted = EncryptionManager.Aes.Encrypt(randomValue.ToString(), keyPair);
            var decrypted = EncryptionManager.Aes.Decrypt<decimal>(encrypted, keyPair);

            Assert.Equal(randomValue, decrypted);
        }

        [Fact]
        public void EncryptionManager_Aes_UrlEncryption()
        {
            var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100));
            var keyPair = EncryptionManager.Aes.GenerateKeyPair();

            var encrypted = EncryptionManager.Aes.UrlEncrypt(randomValue, keyPair);
            var decrypted = EncryptionManager.Aes.UrlDecrypt(encrypted, keyPair);

            Assert.Equal(randomValue, decrypted);
        }

        [Fact]
        public void EncryptionManager_Aes_UrlEncryption_Int()
        {
            var randomValue = new Random(_Seed.Next()).Next(10, 100);
            var keyPair = EncryptionManager.Aes.GenerateKeyPair();

            var encrypted = EncryptionManager.Aes.UrlEncrypt(randomValue.ToString(), keyPair);
            var decrypted = EncryptionManager.Aes.UrlDecrypt<int>(encrypted, keyPair);

            Assert.Equal(randomValue, decrypted);
        }

        [Fact]
        public void EncryptionManager_Aes_UrlEncryption_Double()
        {
            var randomValue = new Random(_Seed.Next()).NextDouble();
            var keyPair = EncryptionManager.Aes.GenerateKeyPair();

            var encrypted = EncryptionManager.Aes.UrlEncrypt(randomValue.ToString(), keyPair);
            var decrypted = EncryptionManager.Aes.UrlDecrypt<double>(encrypted, keyPair);

            Assert.Equal(randomValue, decrypted);
        }

        [Fact]
        public void EncryptionManager_Aes_UrlEncryption_Decimal()
        {
            var randomValue = Convert.ToDecimal(new Random(_Seed.Next()).NextDouble());
            var keyPair = EncryptionManager.Aes.GenerateKeyPair();

            var encrypted = EncryptionManager.Aes.UrlEncrypt(randomValue.ToString(), keyPair);
            var decrypted = EncryptionManager.Aes.UrlDecrypt<decimal>(encrypted, keyPair);

            Assert.Equal(randomValue, decrypted);
        }

        [Fact]
        public void EncryptionManager_TripleDES_NormalEncryption()
        {
            var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100));
            var keyPair = EncryptionManager.TripleDES.GenerateKeyPair();

            var encrypted = EncryptionManager.TripleDES.Encrypt(randomValue, keyPair);
            var decrypted = EncryptionManager.TripleDES.Decrypt(encrypted, keyPair);

            Assert.Equal(randomValue, decrypted);
        }

        [Fact]
        public void EncryptionManager_TripleDES_NormalEncryption_Int()
        {
            var randomValue = new Random(_Seed.Next()).Next(10, 100);
            var keyPair = EncryptionManager.TripleDES.GenerateKeyPair();

            var encrypted = EncryptionManager.TripleDES.Encrypt(randomValue.ToString(), keyPair);
            var decrypted = EncryptionManager.TripleDES.Decrypt<int>(encrypted, keyPair);

            Assert.Equal(randomValue, decrypted);
        }

        [Fact]
        public void EncryptionManager_TripleDES_NormalEncryption_Double()
        {
            var randomValue = new Random(_Seed.Next()).NextDouble();
            var keyPair = EncryptionManager.TripleDES.GenerateKeyPair();

            var encrypted = EncryptionManager.TripleDES.Encrypt(randomValue.ToString(), keyPair);
            var decrypted = EncryptionManager.TripleDES.Decrypt<double>(encrypted, keyPair);

            Assert.Equal(randomValue, decrypted);
        }

        [Fact]
        public void EncryptionManager_TripleDES_NormalEncryption_Decimal()
        {
            var randomValue = Convert.ToDecimal(new Random(_Seed.Next()).NextDouble());
            var keyPair = EncryptionManager.TripleDES.GenerateKeyPair();

            var encrypted = EncryptionManager.TripleDES.Encrypt(randomValue.ToString(), keyPair);
            var decrypted = EncryptionManager.TripleDES.Decrypt<decimal>(encrypted, keyPair);

            Assert.Equal(randomValue, decrypted);
        }

        [Fact]
        public void EncryptionManager_TripleDES_UrlEncryption()
        {
            var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100));
            var keyPair = EncryptionManager.TripleDES.GenerateKeyPair();

            var encrypted = EncryptionManager.TripleDES.UrlEncrypt(randomValue, keyPair);
            var decrypted = EncryptionManager.TripleDES.UrlDecrypt(encrypted, keyPair);

            Assert.Equal(randomValue, decrypted);
        }

        [Fact]
        public void EncryptionManager_TripleDES_UrlEncryption_Int()
        {
            var randomValue = new Random(_Seed.Next()).Next(10, 100);
            var keyPair = EncryptionManager.TripleDES.GenerateKeyPair();

            var encrypted = EncryptionManager.TripleDES.UrlEncrypt(randomValue.ToString(), keyPair);
            var decrypted = EncryptionManager.TripleDES.UrlDecrypt<int>(encrypted, keyPair);

            Assert.Equal(randomValue, decrypted);
        }

        [Fact]
        public void EncryptionManager_TripleDES_UrlEncryption_Double()
        {
            var randomValue = new Random(_Seed.Next()).NextDouble();
            var keyPair = EncryptionManager.TripleDES.GenerateKeyPair();

            var encrypted = EncryptionManager.TripleDES.UrlEncrypt(randomValue.ToString(), keyPair);
            var decrypted = EncryptionManager.TripleDES.UrlDecrypt<double>(encrypted, keyPair);

            Assert.Equal(randomValue, decrypted);
        }

        [Fact]
        public void EncryptionManager_TripleDES_UrlEncryption_Decimal()
        {
            var randomValue = Convert.ToDecimal(new Random(_Seed.Next()).NextDouble());
            var keyPair = EncryptionManager.TripleDES.GenerateKeyPair();

            var encrypted = EncryptionManager.TripleDES.UrlEncrypt(randomValue.ToString(), keyPair);
            var decrypted = EncryptionManager.TripleDES.UrlDecrypt<decimal>(encrypted, keyPair);

            Assert.Equal(randomValue, decrypted);
        }

        #endregion
    }
}
