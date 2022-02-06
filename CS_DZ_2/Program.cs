using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int myGold;
            int cristalCount;
            int priseOfCrislals = 10;

            Console.WriteLine("Приветстыую вас в магазине кристаллов! Цена за один кристалл - " + priseOfCrislals + " золота");
            Console.Write("Сколько у вас золота? ");
            myGold = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько кристаллов вы хотите купить? ");
            cristalCount = Convert.ToInt32(Console.ReadLine());

            myGold -= cristalCount * priseOfCrislals;

            Console.WriteLine("Вы приобрели " + cristalCount + " кристаллов. У вас осталось " + myGold + " золота.");
        }
    }
}
