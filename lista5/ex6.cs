using System;
class uri2670{
  static void Main(){
    int a1 = int.Parse(Console.ReadLine());
    int a2 = int.Parse(Console.ReadLine());
    int a3 = int.Parse(Console.ReadLine());
    int mcafe1 = (a2 * 2) + (a3 * 4);
    int mcafe2 = (a1 * 2) + (a3 * 2);
    int mcafe3 = (a1 * 4) + (a2 * 2);
    int menor = mcafe1;
    if (menor>mcafe2) menor = mcafe2;
    if (menor>mcafe3) menor = mcafe3;
    Console.WriteLine(menor);
    /*if (mcafe1 <= mcafe2) {
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
    }*/
  }
}