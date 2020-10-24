using System;
using System.Security.Cryptography;
using System.Text;

namespace ModularDotNet.Core.Managers
{
    public static class HashManager
    {
        #region Methods

        /// <summary>
        /// Generate random salt key.
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public static string CreateSaltKey(int size)
        {
            var rng = RandomNumberGenerator.Create();
            var buff = new byte[size];
            rng.GetBytes(buff);

            return Convert.ToBase64String(buff);
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
                var crypto = System.Security.Cryptography.MD5.Create();
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes(text));
                return BitConverter.ToString(hashed)
                    .Replace("-", string.Empty);
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

                var crypto = System.Security.Cryptography.MD5.Create();
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes($"{text}{salt}"));
                return BitConverter.ToString(hashed)
                    .Replace("-", string.Empty);
            }

            #endregion
        }

        public static class SHA1
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
                var crypto = System.Security.Cryptography.SHA1.Create();
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes(text));
                return BitConverter.ToString(hashed)
                    .Replace("-", string.Empty);
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

                var crypto = System.Security.Cryptography.SHA1.Create();
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes($"{text}{salt}"));
                return BitConverter.ToString(hashed)
                    .Replace("-", string.Empty);
            }

            #endregion
        }

        public static class SHA256
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
                var crypto = System.Security.Cryptography.SHA256.Create();
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes(text));
                return BitConverter.ToString(hashed)
                    .Replace("-", string.Empty);
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

                var crypto = System.Security.Cryptography.SHA256.Create();
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes($"{text}{salt}"));
                return BitConverter.ToString(hashed)
                    .Replace("-", string.Empty);
            }

            #endregion
        }

        public static class SHA384
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
                var crypto = System.Security.Cryptography.SHA384.Create();
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes(text));
                return BitConverter.ToString(hashed)
                    .Replace("-", string.Empty);
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

                var crypto = System.Security.Cryptography.SHA384.Create();
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes($"{text}{salt}"));
                return BitConverter.ToString(hashed)
                    .Replace("-", string.Empty);
            }

            #endregion
        }

        public static class SHA512
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
                var crypto = System.Security.Cryptography.SHA512.Create();
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes(text));
                return BitConverter.ToString(hashed)
                    .Replace("-", string.Empty);
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

                var crypto = System.Security.Cryptography.SHA512.Create();
                var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes($"{text}{salt}"));
                return BitConverter.ToString(hashed)
                    .Replace("-", string.Empty);
            }

            #endregion
        }

        public static class HMACMD5
        {
            #region Methods

            /// <summary>
            /// Using HMAC MD5 algorithm to hash input text.
            /// </summary>
            /// <param name="text"></param>
            /// <returns></returns>
            public static string Hash(string text, ref byte[] key)
            {
                if (key == null)
                {
                    key = GenerateHashedKey();
                }
                
                using (var crypto = System.Security.Cryptography.HMAC.Create("HMACMD5"))
                {
                    crypto.Key = key;

                    var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes(text));
                    return BitConverter.ToString(hashed)
                        .Replace("-", string.Empty);
                }
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
                if (key == null)
                {
                    key = GenerateHashedKey();
                }

                if (string.IsNullOrEmpty(salt))
                {
                    salt = CreateSaltKey(saltSize);
                }

                using (var crypto = System.Security.Cryptography.HMAC.Create("HMACMD5"))
                {
                    crypto.Key = key;

                    var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes($"{text}{salt}"));
                    return BitConverter.ToString(hashed)
                        .Replace("-", string.Empty);
                }
            }

            #endregion
        }

        public static class HMACSHA1
        {
            #region Methods

            /// <summary>
            /// Using HMAC SHA1 algorithm to hash input text.
            /// </summary>
            /// <param name="text"></param>
            /// <returns></returns>
            public static string Hash(string text, ref byte[] key)
            {
                if (key == null)
                {
                    key = GenerateHashedKey();
                }
                
                using (var crypto = System.Security.Cryptography.HMAC.Create("HMACSHA1"))
                {
                    crypto.Key = key;

                    var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes(text));
                    return BitConverter.ToString(hashed)
                        .Replace("-", string.Empty);
                }
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
                if (key == null)
                {
                    key = GenerateHashedKey();
                }

                if (string.IsNullOrEmpty(salt))
                {
                    salt = CreateSaltKey(saltSize);
                }

                using (var crypto = System.Security.Cryptography.HMAC.Create("HMACSHA1"))
                {
                    crypto.Key = key;

                    var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes($"{text}{salt}"));
                    return BitConverter.ToString(hashed)
                        .Replace("-", string.Empty);
                }
            }

            #endregion
        }

        public static class HMACSHA256
        {
            #region Methods

            /// <summary>
            /// Using HMAC SHA256 algorithm to hash input text.
            /// </summary>
            /// <param name="text"></param>
            /// <returns></returns>
            public static string Hash(string text, ref byte[] key)
            {
                if (key == null)
                {
                    key = GenerateHashedKey();
                }
                
                using (var crypto = System.Security.Cryptography.HMAC.Create("HMACSHA256"))
                {
                    crypto.Key = key;

                    var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes(text));
                    return BitConverter.ToString(hashed)
                        .Replace("-", string.Empty);
                }
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
                if (key == null)
                {
                    key = GenerateHashedKey();
                }

                if (string.IsNullOrEmpty(salt))
                {
                    salt = CreateSaltKey(saltSize);
                }

                using (var crypto = System.Security.Cryptography.HMAC.Create("HMACSHA256"))
                {
                    crypto.Key = key;

                    var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes($"{text}{salt}"));
                    return BitConverter.ToString(hashed)
                        .Replace("-", string.Empty);
                }
            }

            #endregion
        }

        public static class HMACSHA384
        {
            #region Methods

            /// <summary>
            /// Using HMAC SHA384 algorithm to hash input text.
            /// </summary>
            /// <param name="text"></param>
            /// <returns></returns>
            public static string Hash(string text, ref byte[] key)
            {
                if (key == null)
                {
                    key = GenerateHashedKey();
                }
                
                using (var crypto = System.Security.Cryptography.HMAC.Create("HMACSHA384"))
                {
                    crypto.Key = key;

                    var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes(text));
                    return BitConverter.ToString(hashed)
                        .Replace("-", string.Empty);
                }
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
                if (key == null)
                {
                    key = GenerateHashedKey();
                }

                if (string.IsNullOrEmpty(salt))
                {
                    salt = CreateSaltKey(saltSize);
                }

                using (var crypto = System.Security.Cryptography.HMAC.Create("HMACSHA384"))
                {
                    crypto.Key = key;

                    var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes($"{text}{salt}"));
                    return BitConverter.ToString(hashed)
                        .Replace("-", string.Empty);
                }
            }

            #endregion
        }

        public static class HMACSHA512
        {
            #region Methods

            /// <summary>
            /// Using HMAC SHA512 algorithm to hash input text.
            /// </summary>
            /// <param name="text"></param>
            /// <returns></returns>
            public static string Hash(string text, ref byte[] key)
            {
                if (key == null)
                {
                    key = GenerateHashedKey();
                }
                
                using (var crypto = System.Security.Cryptography.HMAC.Create("HMACSHA512"))
                {
                    crypto.Key = key;

                    var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes(text));
                    return BitConverter.ToString(hashed)
                        .Replace("-", string.Empty);
                }
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
                if (key == null)
                {
                    key = GenerateHashedKey();
                }

                if (string.IsNullOrEmpty(salt))
                {
                    salt = CreateSaltKey(saltSize);
                }

                using (var crypto = System.Security.Cryptography.HMAC.Create("HMACSHA512"))
                {
                    crypto.Key = key;

                    var hashed = crypto.ComputeHash(Encoding.UTF8.GetBytes($"{text}{salt}"));
                    return BitConverter.ToString(hashed)
                        .Replace("-", string.Empty);
                }
            }

            #endregion
        }
        
        #endregion
    }
}
