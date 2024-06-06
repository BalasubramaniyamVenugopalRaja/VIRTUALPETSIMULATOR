using System;

public class Pet
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int Hunger { get; private set; }
    public int Happiness { get; private set; }
    public int Health { get; private set; }

    public Pet(string name, string type)
    {
        Name = name;
        Type = type;
        Hunger = 5;
        Happiness = 5;
        Health = 5;
    }

    public void Feed()
    {
        Hunger = Math.Max(0, Hunger - 2);
        Health = Math.Min(10, Health + 1);
        Console.WriteLine($"{Name} has been fed. Hunger decreased, health increased.");
    }

    public void Play()
    {
        Happiness = Math.Min(10, Happiness + 2);
        Hunger = Math.Min(10, Hunger + 1);
        Console.WriteLine($"{Name} played. Happiness increased, but hunger also increased.");
    }

    public void Rest()
    {
        Health = Math.Min(10, Health + 2);
        Happiness = Math.Max(0, Happiness - 1);
        Console.WriteLine($"{Name} is resting. Health increased, but happiness decreased slightly.");
    }

    public void DisplayStatus()
    {
        Console.WriteLine($"Pet's Status - Name: {Name}, Type: {Type}, Hunger: {Hunger}, Happiness: {Happiness}, Health: {Health}");
        CheckWarnings();
    }

    private void CheckWarnings()
    {
        if (Hunger > 8)
            Console.WriteLine($"{Name} is very hungry!");
        if (Happiness < 3)
            Console.WriteLine($"{Name} is unhappy!");
        if (Health < 3)
            Console.WriteLine($"{Name} is in poor health!");
    }

    public void PassTime()
    {
        Hunger = Math.Min(10, Hunger + 1);
        Happiness = Math.Max(0, Happiness - 1);
    }
}

