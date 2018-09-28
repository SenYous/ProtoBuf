using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JianDanGongChang
{
    /// <summary>
    /// 具体产品类：时尚上衣
    /// </summary>
    public class FashionCoat : ICoat
    {
        public void GetYourCoat()
        {
            Console.WriteLine("时尚上衣");
        }
    }
}
