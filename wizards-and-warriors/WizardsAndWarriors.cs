using System;
abstract class Character
{
    protected Character(string characterType)
    {
        Console.WriteLine("Character is a " + characterType);
    }

    public override string ToString()
    {
        return $"Character is a {GetType().Name}";
    }

    public virtual bool Vulnerable()
    {
        return false;
    }

    public abstract int DamagePoints(Character target);
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (target.Vulnerable())
        {
            return 10;
        }
        else
        {
            return 6;
        }
    }
}

class Wizard : Character
{
    private bool spellPrepared;

    public Wizard() : base("Wizard")
    {
        spellPrepared = false; // Initially, wizard has not prepared a spell
    }

    public void PrepareSpell()
    {
        spellPrepared = true;
    }

    public override int DamagePoints(Character target)
    {
        if (spellPrepared)
        {
            return 12;
        }
        else
        {
            return 3;
        }
    }

    public override bool Vulnerable()
    {
        return !spellPrepared;
    }
}