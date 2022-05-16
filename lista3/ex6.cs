using System;

class uri1930{
  static void Main(){
    string lucas = Console.ReadLine();
    string[] incel = lucas.Split();
    double l1 = double.Parse(incel[0]);
    double l2 = double.Parse(incel[1]);
    double l3 = double.Parse(incel[2]);
    double l4 = double.Parse(incel[3]);
    Console.WriteLine(l1+l2+l3+l4-3);
  }
}
