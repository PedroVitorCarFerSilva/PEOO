using System;
class Exercicio8 {
  static void Main() {
    double x = double.Parse(Console.ReadLine());
    Console.WriteLine(MenorInteiro(x));
  }
  public static double MenorInteiro(double x) {
    int i = (int) x;
    int z = 1;
    if (x == i) {
      z--;
    }
    return i+z;
    /*Math.Celling() tambem pode ser usado*/
  }
}