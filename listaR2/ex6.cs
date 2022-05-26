using System;
class exercicio6 {
  static void Main() {
    Console.WriteLine("Digite três valores inteiros");
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());
    int num3 = int.Parse(Console.ReadLine());
    int maior = num1;
    if (maior < num2) maior = num2;
    if (maior < num3) maior = num3;
    int menor = num1;
    if (menor > num2) menor = num2;
    if (menor > num3) menor = num3;
    int soma = maior + menor;
    Console.WriteLine($"A soma do maior com o menor número é {soma}.");
  }
}