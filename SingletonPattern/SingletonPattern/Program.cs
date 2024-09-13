using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var moon = new Moon();
            moon.Create("This is the Moon");
            Console.WriteLine(moon.Planet.Name);

            moon.Planet = Planet.getInstance("This is NOT Moon");
            Console.WriteLine(moon.Planet.Name); //не получится изменить
        
        }

    }

}