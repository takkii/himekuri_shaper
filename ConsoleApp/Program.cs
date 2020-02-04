using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ConsoleApp
{
    public class Himekuri
    {
        public static void Main(string[] args)
        {
            try
            {
                // 宣言
                var dt = DateTime.Now;
                const string str = "令和";
                const string str2 = "R0";

                // 計算
                var reiwa = (str + (dt.Year - 2018) + "年" + dt.Month + "月" + dt.Day + "日");
                var reiwa2 = (str2 + (dt.Year - 2018) + "." + dt.Month + "." + dt.Day);

                // 入れ子
                var count = new DateTime(dt.Year, dt.Month, dt.Day);
                var count2 = new DateTime(dt.Year + 1, 1, 1);
                var gantan = (count2 - count).TotalDays;

                // ソート
                var nengo = (dt.Year + "年" + dt.Month + "月" + dt.Day + "日" + " : " + dt.Hour + "時" + dt.Minute + "分" +
                             dt.Second + "秒");
                var hagoita = reiwa + " : " + reiwa2;
                var oshogatsu = "来年の1月1日まであと：" + (gantan - 1) + "日です。";

                var takoage = new[]
                {
                    new {Name = oshogatsu},
                    new {Name = hagoita},
                    new {Name = nengo}
                };

                var orderByList = takoage.OrderBy(x => x.Name);
                foreach (var x in orderByList )
                {
                    Console.WriteLine(x);
                }
            }

            catch (Exception e)
            {
                // 出力
                Console.WriteLine("Log : " + e);
                Console.ReadKey();
            }
            finally
            {
                // 宣言
                const string ver = "1.0.1";
                const string himekuriShaperVersion = "日めくりの数え番号：" + ver;

                var versioner = new[]
                {
                    new {Version = himekuriShaperVersion}
                };

                var orderList = versioner.OrderBy(y => y.Version);

                foreach (var y in orderList)
                
                {
                    Console.WriteLine(y);
                }

            }
        }
    }
}
