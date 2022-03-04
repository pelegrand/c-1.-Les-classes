
using System;

Random rnd = new Random();

Character char1 = new Character();
char1.attackStrength = rnd.Next(1, 100);
char1.lifePoints = rnd.Next(1, 100);
char1.deffenceStrength = rnd.Next(1, 100);


Character char2 = new Character();
char2.lifePoints = rnd.Next(1, 100);
char2.attackStrength = rnd.Next(1, 100);
char2.deffenceStrength = rnd.Next(1, 100);

char1.getNames(char2);
char1.IsAlive();
char2.IsAlive();

while (char1.lifePoints > 0 && char2.lifePoints > 0)
{
  char1.Attack(char2);
  char1.IsAlive();
  char2.IsAlive();
};

public class Character
{
  public string name;
  public int lifePoints;
  public int attackStrength;
  public int deffenceStrength;
  
  
  public void getNames(Character attacker)
  {
    Console.WriteLine("Enter username:");

    name = Console.ReadLine();

    Console.WriteLine("Enter Attacker Name:");

    attacker.name = Console.ReadLine();

  }
  public void IsAlive()
  {
    if (lifePoints > 0)
    {
      Console.WriteLine(name + " is Alive, life-points :" + lifePoints);
    }
    else
    {
      Console.WriteLine(name + " is dead ");
    }
  }

  public void Attack(Character attacker)
  {
    Console.WriteLine(attacker.name + " Attack " + name + " With " + attacker.attackStrength + " Strength");
    if (attacker.attackStrength < deffenceStrength)
    {
      Console.WriteLine("But " + name + " is strong " + " and defend himself " );
      attacker.lifePoints = (attacker.lifePoints) - (attackStrength - attacker.deffenceStrength);
    }
    else
    {
      Console.WriteLine(name + " loose " + (attacker.attackStrength - deffenceStrength) + " lifepoints ");
      lifePoints = (lifePoints) - (attacker.attackStrength - deffenceStrength);
    }
  }


}


