namespace AbstractFactoryPattern;

class BigGoblin : Goblin
{
    public override void HitWithWeapon()
    {
        Console.WriteLine("Большой гоблин бьёт оружием");
    }
}