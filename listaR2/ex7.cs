using System;
class exercicio7 {
  static void Main(){
    Console.WriteLine("Digite os coeficientes a, b, e c de uma equação do II grau");
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double c = double.Parse(Console.ReadLine());
    double delta = Math.Pow(b, 2) - 4*a*c;
    if (a == 0 || delta < 0) {
      Console.WriteLine("Impossivel calcular");
    }
    else {
      double r1 = (-b + Math.Sqrt(delta)) / (2*a);
      double r2 = (-b - Math.Sqrt(delta)) / (2*a);
      Console.WriteLine($"As raízes são {r1} e {r2}");
    }
  }
}