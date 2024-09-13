namespace DecoratorPattern;

class SyrupIceCream : IceCreamDecorator
{
    public SyrupIceCream(IceCream iceCream) : base(iceCream.Name + " с сиропом", iceCream){}
    
    public override int GetCost()
    {
        return _iceCream.GetCost() + 3;
    }
}