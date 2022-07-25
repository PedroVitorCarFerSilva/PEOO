using System;
class Exercicio4 {
  static void Main() {
    double r = double.Parse(Console.ReadLine());
    Console.WriteLine($"{AreaCirculo(r):0.00}");
  }
  public static double AreaCirculo(double r) {
    return Math.Pow(r, 3) * Math.PI * 4/3;
  }
}