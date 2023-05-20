class Wizard
{
    public enum MagicTypes
    {
        Fire,
        Water,
        Earth,
        Grass,
        Neutral,
    };

    public string name;
    public string mainSpell;
    public MagicTypes magicType;
    public int mana;
    public int health;

    public static int WizardCount;

    // Constructor
    public Wizard(string _name, string _mainSpell, MagicTypes _magicType)
    {
        name = _name;
        mainSpell = _mainSpell;
        magicType = _magicType;
        health = 50;
        mana = 5;
        WizardCount++;
    }

    public void Attack(Wizard enemy)
    {
        if (mana > 0)
        {
            Random damageGen = new Random();
            int damage = damageGen.Next(5, 10);
            Console.WriteLine(name + " attacks " + enemy.name + " dealing " + damage + " damage.\n");
            enemy.health -= damage;
            mana--;
        }
        else
        {
            Console.WriteLine(name + " is out of mana and must take this turn to recharge 2 mana.");
        }

    }

    public void Recharge()
    {
        mana += 2;
    }
}