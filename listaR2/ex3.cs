using System;
class exercicio3 {
  static void Main(){
    Console.WriteLine("Digite quatro valores inteiros");
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());
    int num3 = int.Parse(Console.ReadLine());
    int num4 = int.Parse(Console.ReadLine());
    int somapares = 0;
    if (num1%2 == 0) somapares += num1;
    if (num2%2 == 0) somapares += num2;
    if (num3%2 == 0) somapares += num3;
    if (num4%2 == 0) somapares += num4;
    Console.WriteLine($"Soma dos pares = {somapares}");
    int somaimpares = 0;
    if (num1%2 == 1) somaimpares += num1;
    if (num2%2 == 1) somaimpares += num2;
    if (num3%2 == 1) somaimpares += num3;
    if (num4%2 == 1) somaimpares += num4;
    Console.WriteLine($"Soma dos impares = {somaimpares}");
  }
}