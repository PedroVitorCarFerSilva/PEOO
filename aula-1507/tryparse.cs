using System;
class Program {
  static void Main(){
    Console.WriteLine($"Digite um número");
    bool s = double.TryParse(Console.ReadLine(), out double i);
    if (s) {
      Console.WriteLine($"Número {i} enviado!");
    }
    else {
      Console.WriteLine($"O número é inválido.");
    }
  }
}