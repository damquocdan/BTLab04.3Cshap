using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLab04._3Cshap
{
    /// <summary>
    /// Khai bao giao dien
    /// </summary>
    internal interface IStoreable
    {
        void Read();
        void Write(object data);
    }
}
