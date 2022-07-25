using System;
class Exercicio3 {
  static void Main() {
    double b = double.Parse(Console.ReadLine());
    double h = double.Parse(Console.ReadLine());
    Console.WriteLine(Diagonal(b, h));
  }
  public static double Diagonal(double b, double h) {
    return b*b + h*h;
  }
}