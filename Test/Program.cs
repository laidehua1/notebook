using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //余额宝利滚利计算
            decimal YeRt;
            int days;
            while (true)
            {
                YeRt = Convert.ToDecimal(Console.ReadLine());
                days = Convert.ToInt32(Console.ReadLine());
                decimal DaRt = 1 + YeRt / 365;
                decimal nYeRt = DaRt;
                for (int i = 0; i < days; i++)
                {
                    nYeRt *= DaRt;
                }
                decimal temp = (decimal)365 / (decimal)days;
                nYeRt = (nYeRt - 1) * temp;
                Console.WriteLine(nYeRt);
                int n = Convert.ToInt32(Console.ReadLine());
                if (n == 0)
                    break;
            }
            System.Threading.Thread.Sleep(10000);
        }
    }
}
