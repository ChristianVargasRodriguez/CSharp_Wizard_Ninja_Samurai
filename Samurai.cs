using System.Data.Common;

public class Samurai : Human
{
    public Samurai(string name) : base() 
    {
        Name = name;
        Health = 200;
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
        if (target.Health <= 50){
            target.Health = 0;
        Console.WriteLine($"{Name} attacked {target.Name} and kill it.");
        Console.WriteLine($"Health of {target.Name}: {target.Health} points.");
        }
        else {
        Console.WriteLine($"{Name} attacked {target.Name}, but not deal damage.");
        Console.WriteLine($"Health of {target.Name}: {target.Health} points.");
        }
        return target.Health;
    }

    public int Meditate()
{
        Health = 200; 
        Console.WriteLine($"{Name} meditated and restored their health to full.");
        Console.WriteLine($"Health of {Name}: {Health} points.");
        return Health;
    }
}