namespace DecoratorPattern;

abstract class IceCreamDecorator : IceCream
{
    protected IceCream _iceCream;

    public IceCreamDecorator(string name, IceCream iceCream) : base(name)
    {
        this._iceCream = iceCream;
    }
}