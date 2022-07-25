using System;
class Exercicio1 {
  static void Main() {
    double x = double.Parse(Console.ReadLine());
    double y = double.Parse(Console.ReadLine());
    Console.WriteLine(Menor(x,y));
  }
  public static double Menor(double x, double y) {
    if (x > y) return y;
    else return x;
  }
}