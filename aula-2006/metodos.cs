using System;

class Teste{
  public static void Main(){
    double valor1 = double.Parse(Console.ReadLine());
    double valor2 = double.Parse(Console.ReadLine());
    double area = Program.areatri(valor1, valor2);
    Console.WriteLine($"area = {area}");
    Console.WriteLine($"maior = {Program.maior(valor1, valor2)}");
  }
}

class Program{
  public static double areatri(double x, double y) {
    double area;
    area = x * y / 2;
    return area;
  }
  public static double maior(double x, double y) {
    if (x > y) return x;
    else return y;
  }
}