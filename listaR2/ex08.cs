using System;
class exercicio8 {
  static void Main(){
    Console.WriteLine("Digite quatro valores inteiros");
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());
    int num3 = int.Parse(Console.ReadLine());
    int num4 = int.Parse(Console.ReadLine());
    int maior = num1;
    if (maior < num2) maior = num2;
    if (maior < num3) maior = num3;
    if (maior < num4) maior = num4;
    Console.WriteLine($"Maior valor = {maior}");
    int menor = num1;
    if (menor > num2) menor = num2;
    if (menor > num3) menor = num3;
    if (menor > num4) menor = num4;
    Console.WriteLine($"Menor valor = {menor}");
    int soma = num1+num2+num3+num4-maior-menor;
    Console.WriteLine($"A soma do segundo maior valor com o segundo menor = {soma}");
  }
}