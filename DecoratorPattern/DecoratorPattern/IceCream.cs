namespace DecoratorPattern;

abstract class IceCream
{
    public string Name { get; protected set; }
    public abstract int GetCost();
    
    public IceCream(string name)
    {
        this.Name = name;
    }
}