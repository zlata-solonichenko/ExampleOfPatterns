namespace DecoratorPattern;

class CreamyIceCream : IceCream
{
    public CreamyIceCream() : base("Сливочное мороженное"){}

    public override int GetCost()
    {
        return 20;
    }
}