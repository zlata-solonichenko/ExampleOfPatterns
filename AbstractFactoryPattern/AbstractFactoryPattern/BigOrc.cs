namespace AbstractFactoryPattern;

class BigOrc : Orc
{
    public override void HitWithStick()
    {
        Console.WriteLine("Большой орк бьёт большой палкой");
    }
}