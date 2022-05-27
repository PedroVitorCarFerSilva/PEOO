using System;
class exercicio15 {
  static void Main() {
    Console.WriteLine("Digite três valores:");
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());
    int num3 = int.Parse(Console.ReadLine());
    int maior = num1;
    if (maior < num2) maior = num2;
    if (maior < num3) maior = num3;;
    int menor = num1;
    if (menor > num2) menor = num2;
    if (menor > num3) menor = num3;
    int domeio = num1+num2+num3-maior-menor;
    Console.WriteLine($"{menor}, {domeio}, {maior}");
  }
}