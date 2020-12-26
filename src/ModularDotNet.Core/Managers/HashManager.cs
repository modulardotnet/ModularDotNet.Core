using System;
using System.Security.Cryptography;
using System.Text;

namespace ModularDotNet.Core.Managers
{
    public static class HashManager
    {
        #region Methods

        /// <summary>
        /// Common hash algorithm for hash input text.
        /// </summary>
        /// <param name="crypto"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        private static string CommonHash(HashAlgorithm crypto, string text)
        {
            var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes(text));
            return BitConverter.ToString(hashed)
                .Replace("-", string.Empty);
        }

        /// <summary>
        /// Common HMAC for hash input text.
        /// </summary>
        /// <param name="crypto"></param>
        /// <param name="key"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        private static string CommonHmacHash(string algorithm, ref byte[] key, string text)
        {
            if (key == null)
            {
                key = GenerateHashedKey();
            }

            using (var crypto = System.Security.Cryptography.HMAC.Create(algorithm)) // NOSONAR
            {
                crypto.Key = key;
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes(text));
                return BitConverter.ToString(hashed)
                    .Replace("-", string.Empty);
            }
        }

        /// <summary>
        /// Generate random salt key.
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public static string CreateSaltKey(int size)
        {
            return Convert.ToBase64String(GenerateHashedKey(size));
        }

        /// <summary>
        /// Generate random hashed key.
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public static byte[] GenerateHashedKey(int size = 16)
        {
            var rng = RandomNumberGenerator.Create();
            var buff = new byte[size];
            rng.GetBytes(buff);

            return buff;
        }

        #endregion

        #region Public Classes

        public static class MD5
        {
            #region Methods

            /// <summary>
            /// Using MD5 algorithm to hash input text.
            /// </summary>
            /// <param name="text"></param>
            /// <returns></returns>
            public static string Hash(string text)
            {
                var crypto = System.Security.Cryptography.MD5.Create(); // NOSONAR
                return CommonHash(crypto, text);
            }

            /// <summary>
            /// Using MD5 algorithm to hash input text with provided salt key or auto generate salt key. Default salt key size was 5.
            /// </summary>
            /// <param name="text"></param>
            /// <param name="salt"></param>
            /// <param name="saltSize"></param>
            /// <returns></returns>
            public static string Hash(string text, ref string salt, int saltSize = 6)
            {
                if (string.IsNullOrEmpty(salt))
                {
                    salt = CreateSaltKey(saltSize);
                }

                return Hash($"{text}{salt}");
            }

            #endregion
        }

        public static class Sha1
        {
            #region Methods

            /// <summary>
            /// Using SHA1 algorithm to hash input text.
            /// </summary>
            /// <param name="text"></param>
            /// <returns></returns>
            // ReSharper disable once InconsistentNaming
            public static string Hash(string text)
            {
                var crypto = System.Security.Cryptography.SHA1.Create(); // NOSONAR
                return CommonHash(crypto, text);
            }

            /// <summary>
            /// Using SHA1 algorithm to hash input text with provided salt key or auto generate salt key. Default salt key size was 5.
            /// </summary>
            /// <param name="text"></param>
            /// <param name="salt"></param>
            /// <param name="saltSize"></param>
            /// <returns></returns>
            // ReSharper disable once InconsistentNaming
            public static string Hash(string text, ref string salt, int saltSize = 6)
            {
                if (string.IsNullOrEmpty(salt))
                {
                    salt = CreateSaltKey(saltSize);
                }

                return Hash($"{text}{salt}");
            }

            #endregion
        }

        public static class Sha256
        {
            #region Methods

            /// <summary>
            /// Using SHA256 algorithm to hash input text.
            /// </summary>
            /// <param name="text"></param>
            /// <returns></returns>
            // ReSharper disable once InconsistentNaming
            public static string Hash(string text)
            {
                var crypto = System.Security.Cryptography.SHA256.Create(); // NOSONAR
                return CommonHash(crypto, text);
            }

            /// <summary>
            /// Using SHA256 algorithm to hash input text with provided salt key or auto generate salt key. Default salt key size was 5.
            /// </summary>
            /// <param name="text"></param>
            /// <param name="salt"></param>
            /// <param name="saltSize"></param>
            /// <returns></returns>
            // ReSharper disable once InconsistentNaming
            public static string Hash(string text, ref string salt, int saltSize = 6)
            {
                if (string.IsNullOrEmpty(salt))
                {
                    salt = CreateSaltKey(saltSize);
                }

                return Hash($"{text}{salt}");
            }

            #endregion
        }

        public static class Sha384
        {
            #region Methods

            /// <summary>
            /// Using SHA384 algorithm to hash input text.
            /// </summary>
            /// <param name="text"></param>
            /// <returns></returns>
            // ReSharper disable once InconsistentNaming
            public static string Hash(string text)
            {
                var crypto = System.Security.Cryptography.SHA384.Create(); // NOSONAR
                return CommonHash(crypto, text);
            }

            /// <summary>
            /// Using SHA384 algorithm to hash input text with provided salt key or auto generate salt key. Default salt key size was 5.
            /// </summary>
            /// <param name="text"></param>
            /// <param name="salt"></param>
            /// <param name="saltSize"></param>
            /// <returns></returns>
            // ReSharper disable once InconsistentNaming
            public static string Hash(string text, ref string salt, int saltSize = 6)
            {
                if (string.IsNullOrEmpty(salt))
                {
                    salt = CreateSaltKey(saltSize);
                }

                return Hash($"{text}{salt}");
            }

            #endregion
        }

        public static class Sha512
        {
            #region Methods

            /// <summary>
            /// Using SHA512 algorithm to hash input text.
            /// </summary>
            /// <param name="text"></param>
            /// <returns></returns>
            // ReSharper disable once InconsistentNaming
            public static string Hash(string text)
            {
                var crypto = System.Security.Cryptography.SHA512.Create(); // NOSONAR
                return CommonHash(crypto, text);
            }

            /// <summary>
            /// Using SHA512 algorithm to hash input text with provided salt key or auto generate salt key. Default salt key size was 5.
            /// </summary>
            /// <param name="text"></param>
            /// <param name="salt"></param>
            /// <param name="saltSize"></param>
            /// <returns></returns>
            // ReSharper disable once InconsistentNaming
            public static string Hash(string text, ref string salt, int saltSize = 6)
            {
                if (string.IsNullOrEmpty(salt))
                {
                    salt = CreateSaltKey(saltSize);
                }

                return Hash($"{text}{salt}");
            }

            #endregion
        }

        public static class Sha1Managed
        {
            #region Methods

            /// <summary>
            /// Using SHA1 algorithm to hash input text.
            /// </summary>
            /// <param name="text"></param>
            /// <returns></returns>
            // ReSharper disable once InconsistentNaming
            public static string Hash(string text)
            {
                var crypto = System.Security.Cryptography.SHA1Managed.Create(); // NOSONAR
                return CommonHash(crypto, text);
            }

            /// <summary>
            /// Using SHA1 algorithm to hash input text with provided salt key or auto generate salt key. Default salt key size was 5.
            /// </summary>
            /// <param name="text"></param>
            /// <param name="salt"></param>
            /// <param name="saltSize"></param>
            /// <returns></returns>
            // ReSharper disable once InconsistentNaming
            public static string Hash(string text, ref string salt, int saltSize = 6)
            {
                if (string.IsNullOrEmpty(salt))
                {
                    salt = CreateSaltKey(saltSize);
                }

                return Hash($"{text}{salt}");
            }

            #endregion
        }

        public static class Sha256Managed
        {
            #region Methods

            /// <summary>
            /// Using SHA256 algorithm to hash input text.
            /// </summary>
            /// <param name="text"></param>
            /// <returns></returns>
            // ReSharper disable once InconsistentNaming
            public static string Hash(string text)
            {
                var crypto = System.Security.Cryptography.SHA256Managed.Create(); // NOSONAR
                return CommonHash(crypto, text);
            }

            /// <summary>
            /// Using SHA256 algorithm to hash input text with provided salt key or auto generate salt key. Default salt key size was 5.
            /// </summary>
            /// <param name="text"></param>
            /// <param name="salt"></param>
            /// <param name="saltSize"></param>
            /// <returns></returns>
            // ReSharper disable once InconsistentNaming
            public static string Hash(string text, ref string salt, int saltSize = 6)
            {
                if (string.IsNullOrEmpty(salt))
                {
                    salt = CreateSaltKey(saltSize);
                }

                return Hash($"{text}{salt}");
            }

            #endregion
        }

        public static class Sha384Managed
        {
            #region Methods

            /// <summary>
            /// Using SHA384 algorithm to hash input text.
            /// </summary>
            /// <param name="text"></param>
            /// <returns></returns>
            // ReSharper disable once InconsistentNaming
            public static string Hash(string text)
            {
                var crypto = System.Security.Cryptography.SHA384Managed.Create(); // NOSONAR
                return CommonHash(crypto, text);
            }

            /// <summary>
            /// Using SHA384 algorithm to hash input text with provided salt key or auto generate salt key. Default salt key size was 5.
            /// </summary>
            /// <param name="text"></param>
            /// <param name="salt"></param>
            /// <param name="saltSize"></param>
            /// <returns></returns>
            // ReSharper disable once InconsistentNaming
            public static string Hash(string text, ref string salt, int saltSize = 6)
            {
                if (string.IsNullOrEmpty(salt))
                {
                    salt = CreateSaltKey(saltSize);
                }

                return Hash($"{text}{salt}");
            }

            #endregion
        }

        public static class Sha512Managed
        {
            #region Methods

            /// <summary>
            /// Using SHA512 algorithm to hash input text.
            /// </summary>
            /// <param name="text"></param>
            /// <returns></returns>
            // ReSharper disable once InconsistentNaming
            public static string Hash(string text)
            {
                var crypto = System.Security.Cryptography.SHA512Managed.Create(); // NOSONAR
                return CommonHash(crypto, text);
            }

            /// <summary>
            /// Using SHA512 algorithm to hash input text with provided salt key or auto generate salt key. Default salt key size was 5.
            /// </summary>
            /// <param name="text"></param>
            /// <param name="salt"></param>
            /// <param name="saltSize"></param>
            /// <returns></returns>
            // ReSharper disable once InconsistentNaming
            public static string Hash(string text, ref string salt, int saltSize = 6)
            {
                if (string.IsNullOrEmpty(salt))
                {
                    salt = CreateSaltKey(saltSize);
                }

                return Hash($"{text}{salt}");
            }

            #endregion
        }

        public static class HmacMD5
        {
            #region Methods

            /// <summary>
            /// Using HMAC MD5 algorithm to hash input text.
            /// </summary>
            /// <param name="text"></param>
            /// <returns></returns>
            public static string Hash(string text, ref byte[] key)
            {
                return CommonHmacHash("HMACMD5", ref key, text);
            }

            /// <summary>
            /// Using HMAC MD5 algorithm to hash input text with provided salt key or auto generate salt key. Default salt key size was 5.
            /// </summary>
            /// <param name="text"></param>
            /// <param name="salt"></param>
            /// <param name="saltSize"></param>
            /// <returns></returns>
            public static string Hash(string text, ref byte[] key, ref string salt, int saltSize = 6)
            {
                if (string.IsNullOrEmpty(salt))
                {
                    salt = CreateSaltKey(saltSize);
                }

                return Hash($"{text}{salt}", ref key);
            }

            #endregion
        }

        public static class HmacSha1
        {
            #region Methods

            /// <summary>
            /// Using HMAC SHA1 algorithm to hash input text.
            /// </summary>
            /// <param name="text"></param>
            /// <returns></returns>
            public static string Hash(string text, ref byte[] key)
            {
                return CommonHmacHash("HMACSHA1", ref key, text);
            }

            /// <summary>
            /// Using HMAC SHA1 algorithm to hash input text with provided salt key or auto generate salt key. Default salt key size was 5.
            /// </summary>
            /// <param name="text"></param>
            /// <param name="salt"></param>
            /// <param name="saltSize"></param>
            /// <returns></returns>
            public static string Hash(string text, ref byte[] key, ref string salt, int saltSize = 6)
            {
                if (string.IsNullOrEmpty(salt))
                {
                    salt = CreateSaltKey(saltSize);
                }

                return Hash($"{text}{salt}", ref key);
            }

            #endregion
        }

        public static class HmacSha256
        {
            #region Methods

            /// <summary>
            /// Using HMAC SHA256 algorithm to hash input text.
            /// </summary>
            /// <param name="text"></param>
            /// <returns></returns>
            public static string Hash(string text, ref byte[] key)
            {
                return CommonHmacHash("HMACSHA256", ref key, text);
            }

            /// <summary>
            /// Using HMAC SHA256 algorithm to hash input text with provided salt key or auto generate salt key. Default salt key size was 5.
            /// </summary>
            /// <param name="text"></param>
            /// <param name="salt"></param>
            /// <param name="saltSize"></param>
            /// <returns></returns>
            public static string Hash(string text, ref byte[] key, ref string salt, int saltSize = 6)
            {
                if (string.IsNullOrEmpty(salt))
                {
                    salt = CreateSaltKey(saltSize);
                }

                return Hash($"{text}{salt}", ref key);
            }

            #endregion
        }

        public static class HmacSha384
        {
            #region Methods

            /// <summary>
            /// Using HMAC SHA384 algorithm to hash input text.
            /// </summary>
            /// <param name="text"></param>
            /// <returns></returns>
            public static string Hash(string text, ref byte[] key)
            {
                return CommonHmacHash("HMACSHA384", ref key, text);
            }

            /// <summary>
            /// Using HMAC SHA384 algorithm to hash input text with provided salt key or auto generate salt key. Default salt key size was 5.
            /// </summary>
            /// <param name="text"></param>
            /// <param name="salt"></param>
            /// <param name="saltSize"></param>
            /// <returns></returns>
            public static string Hash(string text, ref byte[] key, ref string salt, int saltSize = 6)
            {
                if (string.IsNullOrEmpty(salt))
                {
                    salt = CreateSaltKey(saltSize);
                }

                return Hash($"{text}{salt}", ref key);
            }

            #endregion
        }

        public static class HmacSha512
        {
            #region Methods

            /// <summary>
            /// Using HMAC SHA512 algorithm to hash input text.
            /// </summary>
            /// <param name="text"></param>
            /// <returns></returns>
            public static string Hash(string text, ref byte[] key)
            {
                return CommonHmacHash("HMACSHA512", ref key, text);
            }

            /// <summary>
            /// Using HMAC SHA512 algorithm to hash input text with provided salt key or auto generate salt key. Default salt key size was 5.
            /// </summary>
            /// <param name="text"></param>
            /// <param name="salt"></param>
            /// <param name="saltSize"></param>
            /// <returns></returns>
            public static string Hash(string text, ref byte[] key, ref string salt, int saltSize = 6)
            {
                if (string.IsNullOrEmpty(salt))
                {
                    salt = CreateSaltKey(saltSize);
                }

                return Hash($"{text}{salt}", ref key);
            }

            #endregion
        }

        #endregion
    }
}
