using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Exchange
    {
        public void MoneyExchange()
        {
            Console.WriteLine("Nhap so tien can doi:");
            bool check = int.TryParse(Console.ReadLine().Trim(), out int amount) && (amount >= 1000);
            while (!check)
            {
                Console.WriteLine("so tien phai lon hon 1000 !");
                check = int.TryParse(Console.ReadLine().Trim(), out amount) && (amount >= 1000);
            }    
            int count = 0;
            int[] money = { 500000, 200000, 100000, 50000, 20000, 10000, 5000, 2000, 1000 };
            for(int i = 0; i < money.Length; i++)
            {
                count = amount / money[i];
                amount = amount % money[i];
                if(count > 0)
                {
                    Console.WriteLine($" {count} dong {money[i]}");
                }    
            }    
        }    
    }
}
