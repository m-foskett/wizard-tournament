class Battle
{
    public int rounds;
    public Wizard wizard1;
    public Wizard wizard2;
    // Constructor
    public Battle(Wizard _wizard1, Wizard _wizard2)
    {
        wizard1 = _wizard1;
        wizard2 = _wizard2;
        rounds = 0;
    }

    public void Round()
    {
        Console.WriteLine("\nThis battle is between " + wizard1.name + "(" + wizard1.health + "HP) and " + wizard2.name + "(" + wizard1.health + "HP)\n");
        while (wizard1.health > 0 && wizard2.health > 0)
        {
            if (wizard1.mana > 0)
            {
                wizard1.Attack(wizard2);
            }
            else
            {
                wizard1.Recharge();
            }
            if (wizard2.health <= 0)
            {
                Console.WriteLine("\nThe winner is " + wizard1.name + " with " + wizard1.health + "HP remaining.\n");
                break;
            }
            if (wizard2.mana > 0)
            {
                wizard2.Attack(wizard1);
            }
            else
            {
                wizard2.Recharge();
            }
            if (wizard1.health <= 0)
            {
                Console.WriteLine("\nThe winner is " + wizard2.name + " with " + wizard2.health + "HP remaining.\n");
                break;
            }
        }

    }
}