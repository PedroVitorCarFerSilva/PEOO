using System;
class exercicio1 {
  static void Main() {
    Console.WriteLine("Digite dois valores inteiros");
    int valor1 = int.Parse(Console.ReadLine());
    int valor2 = int.Parse(Console.ReadLine());
    int maior = valor1;
    if (maior < valor2) {
      maior = valor2;
    }
    Console.WriteLine($"Maior = {maior}");
    
  }
}