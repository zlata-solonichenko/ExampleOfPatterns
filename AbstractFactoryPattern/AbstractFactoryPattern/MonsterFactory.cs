namespace AbstractFactoryPattern;

abstract class MonsterFactory
{
    public abstract Orc CreateOrc();
    public abstract Goblin CreateGoblin();
}