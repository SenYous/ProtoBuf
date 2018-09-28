using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JianDanGongChang
{
    /// <summary>
    /// 简单工厂模式中的核心部分:工厂类
    /// </summary>
    public class Factory
    {
        public ICoat CreateCoat(string styleName)
        {
            switch (styleName.Trim().ToLower())
            {
                case "business": //商务上衣
                    return new BusinessCoat();
                case "fashion"://时尚上衣
                    return new FashionCoat();
                default:
                    throw new Exception("还没有你要的那种衣服");
            }
        }
    }
}
