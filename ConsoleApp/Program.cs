using System;

namespace ConsoleApp
{
    static class Program
    {
        static void Main()
        {
            // Method
            DateTime dt = DateTime.Now;
            string str = "令和";
            string str2 = "R0";
            string ver = "1.0.0";

            // Calc
            var nengo = (dt.Year + "年" + dt.Month + "月" + dt.Day + "日" + " : " + dt.Hour + "時" + dt.Minute + "分" + dt.Second + "秒");
            var reiwa = (str + (dt.Year - 2018) + "年"  + dt.Month + "月" + dt.Day + "日");
            var reiwa2 = (str2 + (dt.Year - 2018) + "." + dt.Month + "." + dt.Day);

            // Count 
            var count = new DateTime(dt.Year , dt.Month, dt.Day);
            var count2 = new DateTime(dt.Year + 1,1,1);
            double interval = (count2 - count).TotalDays;

            // Console
            Console.WriteLine(nengo);
            Console.WriteLine(reiwa + " : " +  reiwa2);
            Console.WriteLine("来年の1月1日まであと：" +(interval-1) + "日です。");
            Console.WriteLine("日めくりの数え番号：" + ver);
            Console.ReadKey();
        }
    }
}
