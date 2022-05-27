using System;
class exercicio14 {
  static void Main() {
    Console.WriteLine("Digite três valores:");
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());
    int num3 = int.Parse(Console.ReadLine());
    string tipo = "escaleno";
    if (num1 == num2 || num1 == num3 || num2 == num3) tipo = "isósceles";
    if (num1 == num2 && num2 == num3) tipo = "equilátero";
    if (num1+num2 > num3 && num1+num3 > num2 && num2+num3 > num1) Console.WriteLine($"Esses valores formam um triângulo {tipo}");
    else Console.WriteLine($"Esses valores não formam um triângulo");
  }
}