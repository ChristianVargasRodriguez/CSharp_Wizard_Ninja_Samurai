public class Human
{
    // Properties for Human
    public string Name {get; set;}
    public int Strength {get; set;}
    public int Intelligence {get; set;}
    public int Dexterity {get; set;}
    public int Health {get; set;}
    public Human()
    {
        Name = "Humano";
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        Health = 100;
    }
    public Human(string name, int strength, int intelligence, int dexterity, int health)
    {
        Name = name;
        Strength = strength;
        Intelligence = intelligence;
        Dexterity = dexterity;
        Health = health;
    }

    public virtual int Attack(Human target)
    {
        int damage = Strength * 3;
        target.Health -= damage;
        Console.WriteLine($"{Name} attacked {target.Name}, dealing {damage} points of damage.");
        return target.Health;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Strength: {Strength}");
        Console.WriteLine($"Intelligence: {Intelligence}");
        Console.WriteLine($"Dexterity: {Dexterity}");
        Console.WriteLine($"Health: {Health}");
    }
}