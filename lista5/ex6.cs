using System;
class uri2670{
  static void Main(){
    double a1 = double.Parse(Console.ReadLine());
    double a2 = double.Parse(Console.ReadLine());
    double a3 = double.Parse(Console.ReadLine());
    double mcafe1 = (a2 * 2) + (a3 * 4);
    double mcafe2 = (a1 * 2) + (a3 * 2);
    double mcafe3 = (a1 * 4) + (a2 * 2);
    if (mcafe1 <= mcafe2) {
      if (mcafe1 <= mcafe3) {
        Console.WriteLine(mcafe1);
      }
      else {
        Console.WriteLine(mcafe3);
      }
    }
    else if (mcafe2 <= mcafe1) {
      if (mcafe2 <= mcafe3) {
        Console.WriteLine(mcafe2);
      }
      else {
        Console.WriteLine(mcafe3);
      }
    }
    else if (mcafe3 <= mcafe1) {
      if (mcafe3 <= mcafe2) {
        Console.WriteLine(mcafe3);
      }
      else {
        Console.WriteLine(mcafe2);
      }
    }
  }
}