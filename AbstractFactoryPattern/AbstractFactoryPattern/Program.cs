using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var smallWizard = new Wizard(new SmallMonsterFactory());
            smallWizard.CreatingOrc();
            smallWizard.CreatingGoblin();

            var bigWizard = new Wizard(new BigMonsterFactory());
            bigWizard.CreatingGoblin();
            bigWizard.CreatingOrc();
        }
    }
}
