using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercitiuStaticMethod
{
    internal class HowManyBeer
    {
        public static int beersInStok;
        public static int beersDrankCount;


        public static void BuyBeer(int bottlesCount)
        {
            beersInStok += bottlesCount;
        }
        
        public static void DrinkBeer(int bottlesCount)
        {
            beersDrankCount += bottlesCount;
            beersInStok -= bottlesCount;
        }

    }
}
