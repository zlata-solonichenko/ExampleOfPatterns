namespace AbstractFactoryPattern;

class Wizard
{
    private Orc _orc;
    private Goblin _goblin;

    public Wizard(MonsterFactory monsterFactory)
    {
        _orc = monsterFactory.CreateOrc();
        _goblin = monsterFactory.CreateGoblin();
    }

    public void CreatingOrc()
    {
        _orc.HitWithStick();
    }

    public void CreatingGoblin()
    {
        _goblin.HitWithWeapon();
    }
}