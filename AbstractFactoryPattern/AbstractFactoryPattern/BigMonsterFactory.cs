namespace AbstractFactoryPattern;

//фабрика создания больших монстров
class BigMonsterFactory : MonsterFactory
{
    public override Orc CreateOrc()
    {
       return new BigOrc();
    }

    public override Goblin CreateGoblin()
    {
        return new BigGoblin();
    }
}