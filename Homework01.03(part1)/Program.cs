namespace Homework01._03_part1_
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Restaurant restaurant = new Restaurant();

            Console.WriteLine("How many Hot Dogs do you want?: ");
            int a = int.Parse(Console.ReadLine());
            Restaurant.MakeHotDog(a);

            //restaurant.MakeHotDog(a);

            Console.WriteLine("How many Sushis do you want?: ");
            int b = int.Parse(Console.ReadLine());
            Restaurant.MakeSushi(b);

            //restaurant.MakeSushi(b);

            Console.WriteLine("How many Burgers do you want?: ");
            int c = int.Parse(Console.ReadLine());
            Restaurant.MakeBurger(c);

            //restaurant.MakeBurger(c);

        }
    }
}