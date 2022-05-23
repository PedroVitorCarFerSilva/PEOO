using System;
class exercicio2 {
  static void Main(){
    Console.WriteLine("Digite quatro valores inteiros");
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());
    int num3 = int.Parse(Console.ReadLine());
    int num4 = int.Parse(Console.ReadLine());
    int media = (num1 + num2 + num3 + num4) / 4;
    Console.WriteLine($"Média = {media}");
    Console.WriteLine("Números menores que a média");
    if (num1 < media) Console.WriteLine(num1); 
    if (num2 < media) Console.WriteLine(num2); 
    if (num3 < media) Console.WriteLine(num3); 
    if (num4 < media) Console.WriteLine(num4); 
    Console.WriteLine("Números maiores ou iguais à média");
    if (num1 > media) Console.WriteLine(num1); 
    if (num2 > media) Console.WriteLine(num2); 
    if (num3 > media) Console.WriteLine(num3); 
    if (num4 > media) Console.WriteLine(num4); 
  }
}