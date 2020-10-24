using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using ModularDotNet.Core.Security;

namespace ModularDotNet.Core.Managers
{
    public static class EncryptionManager
    {
        #region Methods

        private static void ValidateParameters(string input, ref byte[] publicKey, ref byte[] privateKey)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException(nameof(input));
            }

            if (publicKey == null)
            {
                if (Engine.Current?.EncryptionKeyPair?.PublicKey != null)
                {
                    publicKey = Engine.Current?.EncryptionKeyPair?.PublicKey;
                }
                else
                {
                    throw new ArgumentNullException(nameof(publicKey));
                }
            }

            if (privateKey == null)
            {
                if (Engine.Current?.EncryptionKeyPair?.PrivateKey != null)
                {
                    privateKey = Engine.Current?.EncryptionKeyPair?.PrivateKey;
                }
                else
                {
                    throw new ArgumentNullException(nameof(privateKey));
                }
            }
        }

        #endregion

        #region Classes

        public static class Aes
        {
            #region Methods

            /// <summary>
            /// Generate Aes encryption key.
            /// </summary>
            /// <returns></returns>
            public static EncryptionKeyPair GenerateKeyPair()
            {
                var ret = new EncryptionKeyPair();
                using (var aes = System.Security.Cryptography.Aes.Create())
                {
                    aes.GenerateKey();
                    ret.PublicKey = aes.Key;

                    aes.GenerateIV();
                    ret.PrivateKey = aes.IV;
                }

                return ret;
            }

            /// <summary>
            /// Using AES algorithm to decrypt input text.
            /// </summary>
            /// <param name="cipherText"></param>
            /// <param name="publicKey"></param>
            /// <param name="privateKey"></param>
            /// <returns></returns>
            public static string Decrypt(string cipherText, byte[] publicKey = null, byte[] privateKey = null)
            {
                ValidateParameters(cipherText, ref publicKey, ref privateKey);

                var byteArr = Convert.FromBase64String(cipherText);
                string ret;
                using (var aes = System.Security.Cryptography.Aes.Create())
                {
                    aes.Key = publicKey;
                    aes.IV = privateKey;

                    var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                    using (var msDecrypt = new MemoryStream(byteArr))
                    {
                        using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (var srDecrypt = new StreamReader(csDecrypt))
                            {
                                ret = srDecrypt.ReadToEnd();
                            }
                        }
                    }
                }

                return ret;
            }

            /// <summary>
            /// Using AES algorithm to decrypt input text.
            /// </summary>
            /// <param name="cipherText"></param>
            /// <param name="key"></param>
            /// <returns></returns>
            public static string Decrypt(string cipherText, EncryptionKeyPair keyPair)
            {
                return Decrypt(cipherText, keyPair.PublicKey, keyPair.PrivateKey);
            }

            /// <summary>
            /// Using AES algorithm to decrypt input text with casting output type.
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="cipherText"></param>
            /// <param name="publicKey"></param>
            /// <param name="privateKey"></param>
            /// <returns></returns>
            public static T Decrypt<T>(string cipherText, byte[] publicKey = null, byte[] privateKey = null)
            {
                try
                {
                    return (T)Convert.ChangeType(Decrypt(cipherText, publicKey, privateKey), typeof(T));
                }
                catch (Exception)
                {
                    return default;
                }
            }

            /// <summary>
            /// Using AES algorithm to decrypt input text with casting output type.
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="cipherText"></param>
            /// <param name="key"></param>
            /// <returns></returns>
            public static T Decrypt<T>(string cipherText, EncryptionKeyPair keyPair)
            {
                return Decrypt<T>(cipherText, keyPair.PublicKey, keyPair.PrivateKey);
            }

            /// <summary>
            /// Using AES algorithm to encrypt input text.
            /// </summary>
            /// <param name="clearText"></param>
            /// <param name="publicKey"></param>
            /// <param name="privateKey"></param>
            /// <returns></returns>
            public static string Encrypt(string clearText, byte[] publicKey = null, byte[] privateKey = null)
            {
                ValidateParameters(clearText, ref publicKey, ref privateKey);

                byte[] ret;
                using (var aes = System.Security.Cryptography.Aes.Create())
                {
                    aes.Key = publicKey;
                    aes.IV = privateKey;

                    var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                    using (var msEncrypt = new MemoryStream())
                    {
                        using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            using (var swEncrypt = new StreamWriter(csEncrypt))
                            {
                                swEncrypt.Write(clearText);
                            }

                            ret = msEncrypt.ToArray();
                        }
                    }
                }

                return Convert.ToBase64String(ret);
            }

            /// <summary>
            /// Using AES algorithm to encrypt input text.
            /// </summary>
            /// <param name="clearText"></param>
            /// <param name="key"></param>
            /// <returns></returns>
            public static string Encrypt(string clearText, EncryptionKeyPair keyPair)
            {
                return Encrypt(clearText, keyPair.PublicKey, keyPair.PrivateKey);
            }

            /// <summary>
            /// Using AES algorithm to decrypt URL friendly input text.
            /// </summary>
            /// <param name="cipherText"></param>
            /// <param name="publicKey"></param>
            /// <param name="privateKey"></param>
            /// <returns></returns>
            public static string UrlDecrypt(string cipherText, byte[] publicKey = null, byte[] privateKey = null)
            {
                ValidateParameters(cipherText, ref publicKey, ref privateKey);

                var byteArr = Convert.FromBase64String(WebUtility.UrlDecode(cipherText));
                string ret;
                using (var aes = System.Security.Cryptography.Aes.Create())
                {
                    aes.Key = publicKey;
                    aes.IV = privateKey;

                    var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                    using (var msDecrypt = new MemoryStream(byteArr))
                    {
                        using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (var srDecrypt = new StreamReader(csDecrypt))
                            {
                                ret = srDecrypt.ReadToEnd();
                            }
                        }
                    }
                }

                return ret;
            }

            /// <summary>
            /// Using AES algorithm to decrypt URL friendly input text.
            /// </summary>
            /// <param name="cipherText"></param>
            /// <param name="key"></param>
            /// <returns></returns>
            public static string UrlDecrypt(string cipherText, EncryptionKeyPair keyPair)
            {
                return UrlDecrypt(cipherText, keyPair.PublicKey, keyPair.PrivateKey);
            }

            /// <summary>
            /// Using AES algorithm to decrypt URL friendly input text with casting output type.
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="cipherText"></param>
            /// <param name="publicKey"></param>
            /// <param name="privateKey"></param>
            /// <returns></returns>
            public static T UrlDecrypt<T>(string cipherText, byte[] publicKey = null, byte[] privateKey = null)
            {
                try
                {
                    return (T)Convert.ChangeType(UrlDecrypt(cipherText, publicKey, privateKey), typeof(T));
                }
                catch (Exception)
                {
                    return default;
                }
            }

            /// <summary>
            /// Using AES algorithm to decrypt URL friendly input text with casting output type.
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="cipherText"></param>
            /// <param name="key"></param>
            /// <returns></returns>
            public static T UrlDecrypt<T>(string cipherText, EncryptionKeyPair keyPair)
            {
                return UrlDecrypt<T>(cipherText, keyPair.PublicKey, keyPair.PrivateKey);
            }

            /// <summary>
            /// Using AES algorithm to encrypt input text with output URL friendly encrypted text.
            /// </summary>
            /// <param name="clearText"></param>
            /// <param name="publicKey"></param>
            /// <param name="privateKey"></param>
            /// <returns></returns>
            public static string UrlEncrypt(string clearText, byte[] publicKey = null, byte[] privateKey = null)
            {
                ValidateParameters(clearText, ref publicKey, ref privateKey);

                byte[] ret;
                using (var aes = System.Security.Cryptography.Aes.Create())
                {
                    aes.Key = publicKey;
                    aes.IV = privateKey;

                    var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                    using (var msEncrypt = new MemoryStream())
                    {
                        using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            using (var swEncrypt = new StreamWriter(csEncrypt))
                            {
                                swEncrypt.Write(clearText);
                            }

                            ret = msEncrypt.ToArray();
                        }
                    }
                }

                return WebUtility.UrlEncode(Convert.ToBase64String(ret));
            }

            /// <summary>
            /// Using AES algorithm to encrypt input text with output URL friendly encrypted text.
            /// </summary>
            /// <param name="clearText"></param>
            /// <param name="key"></param>
            /// <returns></returns>
            public static string UrlEncrypt(string clearText, EncryptionKeyPair keyPair)
            {
                return UrlEncrypt(clearText, keyPair.PublicKey, keyPair.PrivateKey);
            }
            
            #endregion
        }

        #endregion
    }
}
