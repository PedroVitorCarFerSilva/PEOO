using System;
class Exercicio5 {
  static void Main() {
    double h = double.Parse(Console.ReadLine());
    double l = double.Parse(Console.ReadLine());
    double p = double.Parse(Console.ReadLine());
    Console.WriteLine(VolumeLitros(h, l, p));
  }
  public static double VolumeLitros(double h, double l, double p) {
    return h*l*p;
  }
}