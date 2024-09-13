namespace AbstractFactoryPattern;

class SmallGoblin : Goblin
{
    public override void HitWithWeapon()
    {
        Console.WriteLine("Маленький гоблин бьёт оружием");
    }
}