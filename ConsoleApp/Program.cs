using System;
using System.Collections.Generic;

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

                var list = new List<string>
                {
                    nengo, hagoita, oshogatsu
                };

                list.Sort();

                foreach (var dateTime in list)
                {
                    Console.WriteLine(dateTime);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Log : " + e);
                Console.ReadKey();
            }
            finally
            {
                const string ver = "1.0.1";
                const string himekuriShaperVersion = "日めくりの数え番号：" + ver;

                var listv= new List<string>
                {
                    himekuriShaperVersion
                };

                listv.Sort();

                foreach (var shaper in listv ) 
                {
                    // 出力
                    Console.WriteLine(shaper);
                    Console.ReadKey();
                }
            }
        }
    }
}
