using System;
using System.IO;
using System.Security.Cryptography;

namespace Criptografia.Algoritimos
{
    public class AES
    {
        public byte[] GerarIV()
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.GenerateIV();
                return aesAlg.IV;
            }
        }
        public byte[] EncriptarMensagem(string texto, byte[] chave, byte[] iv)
        {
            byte[] encrypted;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = chave;
                aesAlg.IV = iv;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(texto);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }

                byte[] combinedData = new byte[aesAlg.IV.Length + encrypted.Length];
                Array.Copy(aesAlg.IV, 0, combinedData, 0, aesAlg.IV.Length);
                Array.Copy(encrypted, 0, combinedData, aesAlg.IV.Length, encrypted.Length);

                return combinedData;

            }
        }

        public string DecriptarMensagem(byte[] textocombinado, byte[] chave /*byte[] ivs*/)
        {
            string plaintext = null;

            using (Aes aesAlg = Aes.Create())
            {
                byte[] iv = new byte[aesAlg.BlockSize / 8];
                byte[] cipherText = new byte[textocombinado.Length - iv.Length];
                Array.Copy(textocombinado, iv, iv.Length);
                Array.Copy(textocombinado, iv.Length, cipherText, 0, cipherText.Length);


                aesAlg.Key = chave;
                aesAlg.IV = iv;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            return plaintext;
        }
    }
}
