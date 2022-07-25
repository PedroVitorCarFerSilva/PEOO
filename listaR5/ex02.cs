using System;
class Exercicio2 {
  static void Main() {
    double raio = double.Parse(Console.ReadLine());
    Console.WriteLine($"{AreaCirculo(raio):0.00}");
  }
  public static double AreaCirculo(double raio) {
    return Math.Pow(raio, 2) * Math.PI;
  }
}