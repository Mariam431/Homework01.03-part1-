using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01._03_part1_
{
    internal class Restaurant
    {
        public static int MakeHotDog(ref int a)
        {
            int priceHotDog = 850;
            int fPriceHotDog = a * priceHotDog;
            Console.WriteLine(fPriceHotDog + " AMD");
            return fPriceHotDog;
        }
        public static int MakeSushi(ref int b)
        {
            int priceSushi = 5500;
            int fPriceSushi = b * priceSushi;
            Console.WriteLine(fPriceSushi + " AMD");
            return fPriceSushi;
        }
        public static int MakeBurger(ref int c)
        {
            int priceBurger = 2500;
            int fPriceBurger = c * priceBurger;
            Console.WriteLine(fPriceBurger + " AMD");
            return fPriceBurger;
        }
        //public int Reserve()
        //{
        //    return 0;
        //}
        public Restaurant()
        {

        }//default ctor
        public Restaurant(ref int a, int b, int c) //parametrized ctor
        {
            a = 1;
            b = 1;
            c = 1;
            MakeHotDog(a);
            MakeBurger(b);
            MakeSushi(c);
        }







    }
}
