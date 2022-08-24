using System;
class uri1078 {
  static void Main() {
    int numero = int.Parse(Console.ReadLine());
    for (int mult = 1; mult <= 10; mult++) {
      Console.WriteLine($"{mult} x {numero} = {mult*numero}");
    }
  }
}