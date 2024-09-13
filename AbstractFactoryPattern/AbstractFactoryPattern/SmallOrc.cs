namespace AbstractFactoryPattern;

class SmallOrc : Orc
{
    public override void HitWithStick()
    {
        Console.WriteLine("Маленький орк бьёт палочкой");
    }
}