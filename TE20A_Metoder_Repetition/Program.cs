using System;

Console.WriteLine();

// GetName();

string name = GetName();
Console.WriteLine($"{name} är en kul typ");


int dmg = Attack(5, 99);

Console.WriteLine($"Du gjorde {dmg} i skada!");

Console.ReadLine();

static string GetName()
{
  Console.WriteLine("Type your name:");
  string name = Console.ReadLine();

  return name;
}

static int Attack(int minDmg, int maxDmg)
{
  Random generator = new Random();

  int damage = generator.Next(minDmg, maxDmg);

  return damage;
}