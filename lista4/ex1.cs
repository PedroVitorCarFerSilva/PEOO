using System;
class uri1012{
  static void Main(){
    string selma = Console.ReadLine();
    string[] dantas = selma.Split();
    double a = double.Parse(dantas[0]);
    double b = double.Parse(dantas[1]);
    double c = double.Parse(dantas[2]);
    double tri = a*c/2;
    double cir = 3.14159*Math.Pow(c, 2);
    double tra = ((a+b)*c)/2;
    double qua = b*b;
    double ret = a*b;
    Console.WriteLine($"TRIANGULO: {tri:0.000}");
    Console.WriteLine($"CIRCULO: {cir:0.000}");
    Console.WriteLine($"TRAPEZIO: {tra:0.000}");
    Console.WriteLine($"QUADRADO: {qua:0.000}");
    Console.WriteLine($"RETANGULO: {ret:0.000}");
  }
}