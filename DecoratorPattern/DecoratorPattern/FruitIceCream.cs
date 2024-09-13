namespace DecoratorPattern;

class FruitIceCream : IceCream
{
    public FruitIceCream() : base("Фруктовое мороженное"){}

    public override int GetCost()
    {
        return 15;
    }
}