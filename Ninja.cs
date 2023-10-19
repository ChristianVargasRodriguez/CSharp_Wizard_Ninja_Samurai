using System.Data.Common;

public class Ninja : Human
{
    public Ninja(string name) : base() 
    {
        Name = name;
        Dexterity = 75;
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
        int damage = Dexterity;
        if (new Random().Next(1,101) <= 20){
            damage += 10;
        }
        target.Health -= damage;
        Console.WriteLine($"{Name} attacked {target.Name}, dealing {damage} points of damage.");
        Console.WriteLine($"Health of {target.Name}: {target.Health} points.");
        this.Health += damage;
        Console.WriteLine($"{Name} healed {damage} points. New health: {Health}.");
        return target.Health;
    }

    public int Steal (Human target)
    {
        int steal = 5;
        target.Health -= steal;
        Console.WriteLine($"{Name} steals {steal} Health points from {target.Name}.");
        this.Health += steal;
        Console.WriteLine($"New health of {target.Name}: {target.Health}.");
        Console.WriteLine($"New health of {Name}: {Health}.");
        return target.Health;
    }


}