using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JianDanGongChang
{
    /// <summary>
    /// 客户类
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ICoat food;
            try
            {
                Factory factory = new Factory();
                Console.Write("请选择:时尚上衣 fashion,商务上衣 business\t");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "fashion"://时尚上衣
                        Console.Write("我要的是时尚上衣\t");
                        food = factory.CreateCoat("fashion");
                        food.GetYourCoat();
                        break;
                    case "business": //商务上衣
                        Console.Write("我要的是商务上衣\t");
                        food = factory.CreateCoat("business");
                        food.GetYourCoat();
                        break;
                    default:
                        Console.Write("还没有你要的那种衣服\t");
                        break;
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}

