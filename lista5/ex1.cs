using System;
class uri1036{
  static void Main(){
    string cossito = Console.ReadLine();
    string[] coscas = cossito.Split();
    double a = double.Parse(coscas[0]);
    double b = double.Parse(coscas[1]);
    double c = double.Parse(coscas[2]);
    double delta = Math.Pow(b, 2) - 4*a*c;
    if (a == 0) {
      Console.WriteLine("Impossivel calcular");
    }
    else if (delta < 0) {
      Console.WriteLine("Impossivel calcular");
    }
    else {
      double r1 = (-b + Math.Sqrt(delta)) / (2*a);
      double r2 = (-b - Math.Sqrt(delta)) / (2*a);
      Console.WriteLine($"R1 = {r1:0.00000}");
      Console.WriteLine($"R2 = {r2:0.00000}");
    }
  }
}