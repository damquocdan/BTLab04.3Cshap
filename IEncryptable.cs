using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLab04._3Cshap
{
    internal interface IEncryptable
    { 
        void Encrypt(string plainText, string key);
        void Decrypt(string encrytedText,string key);
    }
}
