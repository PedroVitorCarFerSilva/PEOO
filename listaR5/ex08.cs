using System;
class Exercicio8 {
  static void Main() {
    double x = double.Parse(Console.ReadLine());
    Console.WriteLine(MenorInteiro(x));
  }
  public static double MenorInteiro(double x) {
    string s = x.ToString();
    string[] n = s.Split(".");
    int i = int.Parse(n[0]);
    return i+1;
  }
}