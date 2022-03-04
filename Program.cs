
using System;

Conditions game = new Conditions();

game.test();
public class Conditions
{
  public void test()
  {
    Console.WriteLine("Enter minimum number : ");

    int.TryParse(Console.ReadLine(), out int min);

    Console.WriteLine("Enter a maximum number : ");

    int.TryParse(Console.ReadLine(), out int max);

    Console.WriteLine("Enter a number include between to two firsts :");

    int.TryParse(Console.ReadLine(), out int last);

    while(last<min || last>max){
     if(last < min){
        Console.WriteLine("It must be superior to " + min + " Try again");
        Console.WriteLine("Enter a third number include between to two firsts :");
        int.TryParse(Console.ReadLine(), out last);
      }else{
        Console.WriteLine("It must be inforior to " + max);
        Console.WriteLine("Enter a third number include between to two firsts :");
        int.TryParse(Console.ReadLine(), out last);
      }
    }

    Console.WriteLine("it's ok " + last + " is include between " + min + " and " + max);

  }

}


