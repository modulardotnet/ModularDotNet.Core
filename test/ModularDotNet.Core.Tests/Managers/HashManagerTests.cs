using System;
using System.Security.Cryptography;
using System.Text;
using ModularDotNet.Core.Managers;
using Xunit;

namespace ModularDotNet.Core.Tests.Managers
{
    public class HashManagerTests
    {
        #region Fields

        private static Random _Seed = new Random();

        #endregion

        #region Methods

        [Fact]
        public void HashManager_MD5_Hash()
        {
            var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100));
            var hashedRandomValue = HashManager.MD5.Hash(randomValue);

            var expectedHashed = "";
            using (var crypto = System.Security.Cryptography.MD5.Create())
            {
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes(randomValue));
                expectedHashed = BitConverter.ToString(hashed)
                            .Replace("-", string.Empty);
            }

            Assert.Equal(hashedRandomValue, expectedHashed);
        }

        [Fact]
        public void HashManager_MD5_HashWithSalt()
        {
            var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100));
            var salt = "";
            var hashedRandomValue = HashManager.MD5.Hash(randomValue, ref salt);

            var expectedHashed = "";
            using (var crypto = System.Security.Cryptography.MD5.Create())
            {
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes($"{randomValue}{salt}"));
                expectedHashed = BitConverter.ToString(hashed)
                            .Replace("-", string.Empty);
            }

            Assert.Equal(hashedRandomValue, expectedHashed);
        }

        [Fact]
        public void HashManager_SHA1_Hash()
        {
            var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100));
            var hashedRandomValue = HashManager.SHA1.Hash(randomValue);

            var expectedHashed = "";
            using (var crypto = System.Security.Cryptography.SHA1.Create())
            {
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes(randomValue));
                expectedHashed = BitConverter.ToString(hashed)
                            .Replace("-", string.Empty);
            }

            Assert.Equal(hashedRandomValue, expectedHashed);
        }

        [Fact]
        public void HashManager_SHA1_HashWithSalt()
        {
            var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100));
            var salt = "";
            var hashedRandomValue = HashManager.SHA1.Hash(randomValue, ref salt);

            var expectedHashed = "";
            using (var crypto = System.Security.Cryptography.SHA1.Create())
            {
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes($"{randomValue}{salt}"));
                expectedHashed = BitConverter.ToString(hashed)
                            .Replace("-", string.Empty);
            }

            Assert.Equal(hashedRandomValue, expectedHashed);
        }

        [Fact]
        public void HashManager_SHA256_Hash()
        {
            var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100));
            var hashedRandomValue = HashManager.SHA256.Hash(randomValue);

            var expectedHashed = "";
            using (var crypto = System.Security.Cryptography.SHA256.Create())
            {
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes(randomValue));
                expectedHashed = BitConverter.ToString(hashed)
                            .Replace("-", string.Empty);
            }

            Assert.Equal(hashedRandomValue, expectedHashed);
        }

        [Fact]
        public void HashManager_SHA256_HashWithSalt()
        {
            var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100));
            var salt = "";
            var hashedRandomValue = HashManager.SHA256.Hash(randomValue, ref salt);

            var expectedHashed = "";
            using (var crypto = System.Security.Cryptography.SHA256.Create())
            {
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes($"{randomValue}{salt}"));
                expectedHashed = BitConverter.ToString(hashed)
                            .Replace("-", string.Empty);
            }

            Assert.Equal(hashedRandomValue, expectedHashed);
        }

        [Fact]
        public void HashManager_SHA384_Hash()
        {
            var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100));
            var hashedRandomValue = HashManager.SHA384.Hash(randomValue);

            var expectedHashed = "";
            using (var crypto = System.Security.Cryptography.SHA384.Create())
            {
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes(randomValue));
                expectedHashed = BitConverter.ToString(hashed)
                            .Replace("-", string.Empty);
            }

            Assert.Equal(hashedRandomValue, expectedHashed);
        }

        [Fact]
        public void HashManager_SHA384_HashWithSalt()
        {
            var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100));
            var salt = "";
            var hashedRandomValue = HashManager.SHA384.Hash(randomValue, ref salt);

            var expectedHashed = "";
            using (var crypto = System.Security.Cryptography.SHA384.Create())
            {
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes($"{randomValue}{salt}"));
                expectedHashed = BitConverter.ToString(hashed)
                            .Replace("-", string.Empty);
            }

            Assert.Equal(hashedRandomValue, expectedHashed);
        }

        [Fact]
        public void HashManager_SHA512_Hash()
        {
            var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100));
            var hashedRandomValue = HashManager.SHA512.Hash(randomValue);

            var expectedHashed = "";
            using (var crypto = System.Security.Cryptography.SHA512.Create())
            {
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes(randomValue));
                expectedHashed = BitConverter.ToString(hashed)
                            .Replace("-", string.Empty);
            }

            Assert.Equal(hashedRandomValue, expectedHashed);
        }

        [Fact]
        public void HashManager_SHA512_HashWithSalt()
        {
            var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100));
            var salt = "";
            var hashedRandomValue = HashManager.SHA512.Hash(randomValue, ref salt);

            var expectedHashed = "";
            using (var crypto = System.Security.Cryptography.SHA512.Create())
            {
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes($"{randomValue}{salt}"));
                expectedHashed = BitConverter.ToString(hashed)
                            .Replace("-", string.Empty);
            }

            Assert.Equal(hashedRandomValue, expectedHashed);
        }
        

        [Fact]
        public void HashManager_HMACMD5_Hash()
        {
            var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100));
            byte[] key = null;
            var hashedRandomValue = HashManager.HMACMD5.Hash(randomValue, ref key);

            var expectedHashed = "";
            using (var crypto = HMAC.Create("HMACMD5"))
            {
                crypto.Key = key;
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes(randomValue));
                expectedHashed = BitConverter.ToString(hashed)
                            .Replace("-", string.Empty);
            }

            Assert.Equal(hashedRandomValue, expectedHashed);
        }

        [Fact]
        public void HashManager_HMACMD5_HashWithSalt()
        {
            var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100));
            var salt = "";
            byte[] key = null;
            var hashedRandomValue = HashManager.HMACMD5.Hash(randomValue, ref key, ref salt);

            var expectedHashed = "";
            using (var crypto = HMAC.Create("HMACMD5"))
            {
                crypto.Key = key;
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes($"{randomValue}{salt}"));
                expectedHashed = BitConverter.ToString(hashed)
                            .Replace("-", string.Empty);
            }

            Assert.Equal(hashedRandomValue, expectedHashed);
        }

        [Fact]
        public void HashManager_HMACMD5_Hash_RandomKey()
        {
            var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100));
            byte[] key = HashManager.GenerateHashedKey(new Random(_Seed.Next()).Next(1, 128));
            var hashedRandomValue = HashManager.HMACMD5.Hash(randomValue, ref key);

            var expectedHashed = "";
            using (var crypto = HMAC.Create("HMACMD5"))
            {
                crypto.Key = key;
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes(randomValue));
                expectedHashed = BitConverter.ToString(hashed)
                            .Replace("-", string.Empty);
            }

            Assert.Equal(hashedRandomValue, expectedHashed);
        }

        [Fact]
        public void HashManager_HMACSHA1_Hash()
        {
            var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100));
            byte[] key = null;
            var hashedRandomValue = HashManager.HMACSHA1.Hash(randomValue, ref key);

            var expectedHashed = "";
            using (var crypto = HMAC.Create("HMACSHA1"))
            {
                crypto.Key = key;
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes(randomValue));
                expectedHashed = BitConverter.ToString(hashed)
                            .Replace("-", string.Empty);
            }

            Assert.Equal(hashedRandomValue, expectedHashed);
        }

        [Fact]
        public void HashManager_HMACSHA1_HashWithSalt()
        {
            var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100));
            var salt = "";
            byte[] key = null;
            var hashedRandomValue = HashManager.HMACSHA1.Hash(randomValue, ref key, ref salt);

            var expectedHashed = "";
            using (var crypto = HMAC.Create("HMACSHA1"))
            {
                crypto.Key = key;
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes($"{randomValue}{salt}"));
                expectedHashed = BitConverter.ToString(hashed)
                            .Replace("-", string.Empty);
            }

            Assert.Equal(hashedRandomValue, expectedHashed);
        }

        [Fact]
        public void HashManager_HMACSHA1_Hash_RandomKey()
        {
            var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100));
            byte[] key = HashManager.GenerateHashedKey(new Random(_Seed.Next()).Next(1, 128));
            var hashedRandomValue = HashManager.HMACSHA1.Hash(randomValue, ref key);

            var expectedHashed = "";
            using (var crypto = HMAC.Create("HMACSHA1"))
            {
                crypto.Key = key;
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes(randomValue));
                expectedHashed = BitConverter.ToString(hashed)
                            .Replace("-", string.Empty);
            }

            Assert.Equal(hashedRandomValue, expectedHashed);
        }

        [Fact]
        public void HashManager_HMACSHA256_Hash()
        {
            var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100));
            byte[] key = null;
            var hashedRandomValue = HashManager.HMACSHA256.Hash(randomValue, ref key);

            var expectedHashed = "";
            using (var crypto = HMAC.Create("HMACSHA256"))
            {
                crypto.Key = key;
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes(randomValue));
                expectedHashed = BitConverter.ToString(hashed)
                            .Replace("-", string.Empty);
            }

            Assert.Equal(hashedRandomValue, expectedHashed);
        }

        [Fact]
        public void HashManager_HMACSHA256_HashWithSalt()
        {
            var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100));
            var salt = "";
            byte[] key = null;
            var hashedRandomValue = HashManager.HMACSHA256.Hash(randomValue, ref key, ref salt);

            var expectedHashed = "";
            using (var crypto = HMAC.Create("HMACSHA256"))
            {
                crypto.Key = key;
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes($"{randomValue}{salt}"));
                expectedHashed = BitConverter.ToString(hashed)
                            .Replace("-", string.Empty);
            }

            Assert.Equal(hashedRandomValue, expectedHashed);
        }

        [Fact]
        public void HashManager_HMACSHA256_Hash_RandomKey()
        {
            var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100));
            byte[] key = HashManager.GenerateHashedKey(new Random(_Seed.Next()).Next(1, 128));
            var hashedRandomValue = HashManager.HMACSHA256.Hash(randomValue, ref key);

            var expectedHashed = "";
            using (var crypto = HMAC.Create("HMACSHA256"))
            {
                crypto.Key = key;
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes(randomValue));
                expectedHashed = BitConverter.ToString(hashed)
                            .Replace("-", string.Empty);
            }

            Assert.Equal(hashedRandomValue, expectedHashed);
        }

        [Fact]
        public void HashManager_HMACSHA384_Hash()
        {
            var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100));
            byte[] key = null;
            var hashedRandomValue = HashManager.HMACSHA384.Hash(randomValue, ref key);

            var expectedHashed = "";
            using (var crypto = HMAC.Create("HMACSHA384"))
            {
                crypto.Key = key;
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes(randomValue));
                expectedHashed = BitConverter.ToString(hashed)
                            .Replace("-", string.Empty);
            }

            Assert.Equal(hashedRandomValue, expectedHashed);
        }

        [Fact]
        public void HashManager_HMACSHA384_HashWithSalt()
        {
            var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100));
            var salt = "";
            byte[] key = null;
            var hashedRandomValue = HashManager.HMACSHA384.Hash(randomValue, ref key, ref salt);

            var expectedHashed = "";
            using (var crypto = HMAC.Create("HMACSHA384"))
            {
                crypto.Key = key;
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes($"{randomValue}{salt}"));
                expectedHashed = BitConverter.ToString(hashed)
                            .Replace("-", string.Empty);
            }

            Assert.Equal(hashedRandomValue, expectedHashed);
        }

        [Fact]
        public void HashManager_HMACSHA384_Hash_RandomKey()
        {
            var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100));
            byte[] key = HashManager.GenerateHashedKey(new Random(_Seed.Next()).Next(1, 128));
            var hashedRandomValue = HashManager.HMACSHA384.Hash(randomValue, ref key);

            var expectedHashed = "";
            using (var crypto = HMAC.Create("HMACSHA384"))
            {
                crypto.Key = key;
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes(randomValue));
                expectedHashed = BitConverter.ToString(hashed)
                            .Replace("-", string.Empty);
            }

            Assert.Equal(hashedRandomValue, expectedHashed);
        }

        [Fact]
        public void HashManager_HMACSHA512_Hash()
        {
            var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100));
            byte[] key = null;
            var hashedRandomValue = HashManager.HMACSHA512.Hash(randomValue, ref key);

            var expectedHashed = "";
            using (var crypto = HMAC.Create("HMACSHA512"))
            {
                crypto.Key = key;
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes(randomValue));
                expectedHashed = BitConverter.ToString(hashed)
                            .Replace("-", string.Empty);
            }

            Assert.Equal(hashedRandomValue, expectedHashed);
        }

        [Fact]
        public void HashManager_HMACSHA512_HashWithSalt()
        {
            var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100));
            var salt = "";
            byte[] key = null;
            var hashedRandomValue = HashManager.HMACSHA512.Hash(randomValue, ref key, ref salt);

            var expectedHashed = "";
            using (var crypto = HMAC.Create("HMACSHA512"))
            {
                crypto.Key = key;
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes($"{randomValue}{salt}"));
                expectedHashed = BitConverter.ToString(hashed)
                            .Replace("-", string.Empty);
            }

            Assert.Equal(hashedRandomValue, expectedHashed);
        }

        [Fact]
        public void HashManager_HMACSHA512_Hash_RandomKey()
        {
            var randomValue = "".GenerateRandomString(new Random(_Seed.Next()).Next(10, 100));
            byte[] key = HashManager.GenerateHashedKey(new Random(_Seed.Next()).Next(1, 128));
            var hashedRandomValue = HashManager.HMACSHA512.Hash(randomValue, ref key);

            var expectedHashed = "";
            using (var crypto = HMAC.Create("HMACSHA512"))
            {
                crypto.Key = key;
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes(randomValue));
                expectedHashed = BitConverter.ToString(hashed)
                            .Replace("-", string.Empty);
            }

            Assert.Equal(hashedRandomValue, expectedHashed);
        }

        #endregion
    }
}
