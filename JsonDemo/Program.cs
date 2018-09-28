using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = new DateTime(2018, 09, 20);
            DateTime dt2 = DateTime.Now;
            double timeMin = (dt2 - dt1).TotalMinutes;
            //var iMinutes = dt2 - dt1;
            //string time = $"{iMinutes.Days}天{iMinutes.Hours}小时{iMinutes.Minutes}";

            //var timeMin = (dt2 - dt1).TotalHours;

            decimal[] p = { 18.72M, 20.72M, 21.60M, 23.00M, 43.20M };
            Array.Reverse(p);
            decimal _max = 19911.14M;// 234.11M;
            MaxNumber(0, _max, p);
            Console.WriteLine("完成");
            Console.ReadKey();
        }

        public static int MaxNumber(int item, decimal re, decimal[] p)
        {
            for (int i = Convert.ToInt32(re / p[item]); i > 0; i--)
            {
                if (item == 0)
                    Console.WriteLine(i);
                decimal minNum = re - p[item] * i;
                if (minNum < 0)
                    continue;
                else if (minNum == 0)
                {
                    Console.WriteLine($"{item}---{p[item]}-----{i}----{p[item] * i}");
                    return 0;
                }
                else if (re > 0 && item < p.Length - 1)
                {
                    if (MaxNumber(item + 1, minNum, p) == 0)
                    {
                        Console.WriteLine($"{item}---{p[item]}-----{i}----{p[item] * i}");
                        return 0;
                    }
                }
            }
            return 1;
        }
    }
}
