using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IceCream iceCream1 = new FruitIceCream();
            iceCream1 = new BerriesIceCream(iceCream1);
            
            Console.WriteLine($"Название {iceCream1.Name}");
            Console.WriteLine($"Цена {iceCream1.GetCost()}");
            Console.WriteLine("-------------");
            
            IceCream iceCream2 = new FruitIceCream();
            iceCream2 = new SyrupIceCream(iceCream2);
            
            Console.WriteLine($"Название {iceCream2.Name}");
            Console.WriteLine($"Цена {iceCream2.GetCost()}");
            Console.WriteLine("-------------");
            
            IceCream iceCream3 = new CreamyIceCream();
            iceCream3 = new BerriesIceCream(iceCream3);
            iceCream3 = new SyrupIceCream(iceCream3);
            
            Console.WriteLine($"Название {iceCream3.Name}");
            Console.WriteLine($"Цена {iceCream3.GetCost()}");
            Console.WriteLine("-------------");
        }
    }
}