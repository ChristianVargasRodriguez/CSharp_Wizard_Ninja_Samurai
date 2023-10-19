using System.Data.Common;

public class Wizard : Human
{
    public Wizard(string name) : base() 
    {
        Name = name;
        Intelligence = 25;
        Health = 50;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Strength: {Strength}");
        Console.WriteLine($"Intelligence: {Intelligence}");
        Console.WriteLine($"Dexterity: {Dexterity}");
        Console.WriteLine($"Health: {Health}");
    }

    public override int Attack(Human target)
    {
        int damage = Intelligence * 3;
        target.Health -= damage;
        Console.WriteLine($"{Name} attacked {target.Name}, dealing {damage} points of damage.");
        Console.WriteLine($"Health of {target.Name}: {target.Health} points.");
        this.Health += damage;
        Console.WriteLine($"{Name} healed {damage} points.");
        return target.Health;
    }

    public int Heal (Human target)
    {
        int heals = Intelligence * 3;
        target.Health += heals;
        Console.WriteLine($"{Name} heals {target.Name} for {heals} Health points.");
        Console.WriteLine($"Health of {target.Name}: {target.Health} points.");
        return target.Health;
    }


}