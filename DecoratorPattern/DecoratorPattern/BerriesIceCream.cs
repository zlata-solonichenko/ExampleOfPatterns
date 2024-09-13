namespace DecoratorPattern;

class BerriesIceCream : IceCreamDecorator
{
    public BerriesIceCream(IceCream iceCream) : base(iceCream.Name + " с ягодами", iceCream){}
    
    public override int GetCost()
    {
        return _iceCream.GetCost() + 5;
    }
}