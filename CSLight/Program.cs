using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            int gold;
            int crystall = 10;
            int overCrystall;
            int totalCrystall;

            Console.WriteLine("Привет! Один кристалл стоит десять золота");
            Console.WriteLine("Сколько у вас золота?");
            gold = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сколько кристаллов хотите купить?");
            overCrystall = Convert.ToInt32(Console.ReadLine());
            overCrystall *= crystall;

            if (gold < 0 || overCrystall > gold)
            {
                Console.WriteLine("У вас не достаточно золота");
                Console.ReadKey();
            }          
            else 
            {                
                gold -= overCrystall;
                totalCrystall = overCrystall / 10;
                Console.WriteLine("У вас - " + totalCrystall + " кристаллов " + gold + " золота");
                Console.ReadKey();
            }
        }
    }
}
