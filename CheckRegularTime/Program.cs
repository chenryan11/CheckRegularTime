using System;

namespace CheckRegularTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入 小時:分鐘");

            RegularTime regulartime = new RegularTime();

            regulartime.MilitaryTimeToRegularTime();
        }
    }
}
