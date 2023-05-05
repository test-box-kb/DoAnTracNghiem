using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTracNghiem.DAO
{
   public class MaHoa
    {
        private static MaHoa instance;
        public static MaHoa Instance
        {
            get { if (instance == null) instance = new MaHoa(); return instance; }
            private set { instance = value; }
        }
        public string hashstring(string mess, string algo)
        {
            string hashcode = "";
            byte[] x_message_data = Encoding.Default.GetBytes(mess);
            HashAlgorithm x_hash_alg = HashAlgorithm.Create(algo);
            byte[] x_hash_code = x_hash_alg.ComputeHash(x_message_data);
            hashcode = BitConverter.ToString(x_hash_code);
            return hashcode;
        }
        public string EncryptString(string plaintext, byte[] key, byte[] iv)
        {
            Aes encrypt = Aes.Create();
            encrypt.Mode = CipherMode.CBC;
            encrypt.Key = key;
            encrypt.IV = iv;
            MemoryStream m = new MemoryStream();
            ICryptoTransform aesencrypt = encrypt.CreateEncryptor();
            CryptoStream cryptoStream = new CryptoStream(m, aesencrypt, CryptoStreamMode.Write);
            byte[] plain = Encoding.ASCII.GetBytes(plaintext);
            cryptoStream.Write(plain, 0, plain.Length);
            cryptoStream.FlushFinalBlock();
            byte[] cipher = m.ToArray();
            m.Close();
            cryptoStream.Close();
            string ciphertext = Convert.ToBase64String(cipher, 0, cipher.Length);
            return ciphertext;
        }
        public string DecryptString(string cipherText, byte[] key, byte[] iv)
        {
            Aes encryptor = Aes.Create();
            encryptor.Mode = CipherMode.CBC;
            encryptor.Key = key;
            encryptor.IV = iv;

            MemoryStream memoryStream = new MemoryStream();
            ICryptoTransform aesDecryptor = encryptor.CreateDecryptor();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, aesDecryptor, CryptoStreamMode.Write);

            string plainText = String.Empty;

            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            cryptoStream.Write(cipherBytes, 0, cipherBytes.Length);
            cryptoStream.FlushFinalBlock();
            byte[] plainBytes = memoryStream.ToArray();
            plainText = Encoding.ASCII.GetString(plainBytes, 0, plainBytes.Length);

            memoryStream.Close();
            cryptoStream.Close();

            return plainText;
        }
        public string HashCodeEnCryp(string pass)
        {
            string password = "kieubao";
            byte[] iv = new byte[16] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            SHA256 sHA256 = SHA256Managed.Create();
            byte[] key = sHA256.ComputeHash(Encoding.ASCII.GetBytes(password));
            string hashcode = hashstring(pass, "SHA512");
            hashstring(password, "SHA512");
            string encrypted = MaHoa.Instance.EncryptString(hashcode, key, iv);
            hashcode = encrypted;
           return hashcode;
        }
    }
}
