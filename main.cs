using System;

class MainClass {
  public static void Main (string[] args) {
    //Between 10 and 500, find all numbers divisible by 7
    for(int num=10; num<=50; num++)
    {
      if (num % 7 != 0)//not divisible by 7
        continue;

      Console.WriteLine(num);

    }
    Console.WriteLine("Outside the loop");
  }
}