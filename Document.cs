using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLab04._3Cshap
{
    public class Document : IStoreable, IEncryptable
    {
        #region "Thuc thi ca phuong thuc tu giao dien IEncryptable"

        public void Decrypt(string encryptedText,string key)
        {
            StringBuilder sb = new StringBuilder(encryptedText.Length);
            for(int i = 0; i < encryptedText.Length; i++)
            {
                encryptedText.Append((char)(encryptedText[i] ^ key[i % key.Length]));
            }
        }

        public void Encrypt( string plainText, string key)
        {
            StringBuilder sb = new StringBuilder(plainText.Length);
            for (int i = 0; i < plainText.Length; i++)
            {
                plainText.Append((char)(plainText[i] ^ key[i % key.Length]));
            }
        }

        #endregion

        #region"thuc thi cac phuong thuc tu dao dien IStoreable"
        public void Read()
        {
            Console.WriteLine("Doc du lieu tu file");
        }

        public void Write(object data)
        {
            Console.WriteLine("luu noi dung cua  "+data+"vao file");
        }



        #endregion
    }
}