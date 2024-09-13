namespace AbstractFactoryPattern;

//фабрика создания маленьких монстров
class SmallMonsterFactory : MonsterFactory
{
    public override Orc CreateOrc()
    {
        return new SmallOrc();
    }

    public override Goblin CreateGoblin()
    {
        return new SmallGoblin();
    }
}