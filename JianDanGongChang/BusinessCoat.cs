using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JianDanGongChang
{
    /// <summary>
    /// 具体产品类：商务上衣
    /// </summary>
    public class BusinessCoat : ICoat
    {
        public void GetYourCoat()
        {
            Console.WriteLine("商务上衣");
        }
    }
}
