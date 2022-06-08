using System;
class uri1116 {
  static void Main() {
    int contas = int.Parse(Console.ReadLine());
    for (int i = 0; i < contas; i++) {
      string valores = Console.ReadLine();
      string[] valor = valores.Split();
      int dividendo = int.Parse(valor[0]);
      int divisor = int.Parse(valor[1]);
      if (divisor != 0) Console.WriteLine($"{dividendo/1.0/divisor:0.0}");
      else Console.WriteLine("divisao impossivel");
    }
  }
}